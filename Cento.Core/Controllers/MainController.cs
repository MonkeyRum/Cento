using Cento.Core.Project;
using Cento.Core.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.Controllers
{
    public class MainController : Controller, Cento.Core.Controllers.IMainController
    {
        #region Members

        private IMainView _view = null;

        #endregion

        #region Constructors

        public MainController()
        {
            TheProject.Instance.ProjectFilenameChanged += Instance_ProjectFilenameChanged;
        }

        #endregion

        #region Properties

        public IMainView View
        {
            get
            {
                return this._view;
            }
            set
            {
                if(this.View != null)
                {
                    this.View.ProjectOpened -= View_ProjectOpened;
                }

                if (value != null)
                {
                    this._view = value;
                    this.View.ProjectOpened += View_ProjectOpened;
                }
            }
        }

        #endregion

        #region Methods

        public bool OpenProject(string filename)
        {
            bool bSuccess = false;

            try
            {
                bSuccess = TheProject.Instance.OpenProject(filename);
                InitNewProjectView();
            }
            catch (Exception e)
            {
                bSuccess = false;
            }

            return bSuccess;
        }

        private void InitNewProjectView()
        {
            SetViewFilename(TheProject.Instance.ProjectFilename);
        }

        private void SetViewFilename(string filename)
        {
            if (this.View != null)
            {
                this.View.Filename = filename;
            }
        }

        #endregion

        #region Overrides

        public override void ShowView()
        {
            if(this.View != null)
            {
                this.View.Show();
            }
        }

        #endregion

        #region Event Handlers

        void Instance_ProjectFilenameChanged(object sender, EventArgs e)
        {
            this.View.Filename = TheProject.Instance.ProjectFilename;
        }

        void View_ProjectOpened(object sender, ProjectOpenedEventArgs e)
        {
            this.OpenProject(e.Filename);
        }

        #endregion
    }
}
