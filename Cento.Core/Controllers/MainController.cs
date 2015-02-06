using Cento.Core.Project;
using Cento.Core.View;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        List<Image> _images = new List<Image>();

        #endregion

        #region Constructors

        public MainController()
        {
            CentoCore.Instance.ProjectFilenameChanged += Instance_ProjectFilenameChanged;
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
                bSuccess = CentoCore.Instance.OpenProject(filename);
                InitNewProjectView();
            }
            catch(IOException e)
            {
                this.View.DisplayErrorMessage("IO Error", e.Message);
            }
            catch (Exception e)
            {
                bSuccess = false;
                this.View.DisplayErrorMessage("Error", e.Message);
            }

            return bSuccess;
        }

        private void InitNewProjectView()
        {
            SetViewProjectFilename(CentoCore.Instance.ProjectFilename);
            LoadImages();
            SetCurrentImage();
        }

        private void LoadImages()
        {
            foreach(var dataImage in CentoCore.Instance.DataImages)
            {
                string filename = Path.Combine(CentoCore.Instance.ProjectFolderPath, dataImage.Filename);
                Image img = Image.FromFile(filename);
                this._images.Add(img);
            }
        }

        private void SetViewProjectFilename(string projectFilename)
        {
            if (this.View != null)
            {
                this.View.ProjectFilename = projectFilename;
            }
        }

        private void SetCurrentImage(int index = 0)
        {
            this.View.CurrentImage = this._images[index];
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
            this.View.ProjectFilename = CentoCore.Instance.ProjectFilename;
        }

        void View_ProjectOpened(object sender, ProjectOpenedEventArgs e)
        {
            this.OpenProject(e.ProjectFilename);
        }

        #endregion
    }
}
