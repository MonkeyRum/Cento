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
        private int _currentDataImageIndex = -1;

        #endregion

        #region Constructors

        public MainController(IMainView view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            this.View = view;

            CentoCore.Instance.ProjectOpened += Instance_ProjectOpened;

            this.View.Actions.OpenProject += Actions_OpenProject;

            this.View.Actions.FirstDataImage += Actions_FirstDataImage;
            this.View.Actions.PreviousDataImage += Actions_PreviousDataImage;
            this.View.Actions.NextDataImage += Actions_NextDataImage;
            this.View.Actions.LastDataImage += Actions_LastDataImage;
            this.View.Actions.SelectDataImageIndexChanged += Actions_SelectDataImageIndexChanged;
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
                this._view = value;
            }
        }

        #endregion

        #region Methods
        
        private void InitProjectView()
        {
            this.View.ProjectFilename = CentoCore.Instance.ProjectFilename;

            List<CentoProjectDataImage> dataImages = new List<CentoProjectDataImage>(CentoCore.Instance.DataImageCount);
            foreach(var dataImage in CentoCore.Instance.DataImages())
            {
                dataImages.Add(dataImage);
            }
            this.View.DataImageList = dataImages;

            // will except if the project happens to be empty
            this.View.CurrentDataImage = CentoCore.Instance.GetDataImageFromIndex(0);

            SetMoveButtonsEnabledStatus();
        }

        private void SetCurrentDataImage(int index)
        {
            // will except when out of bounds
            var dataImage = CentoCore.Instance.GetDataImageFromIndex(index);
            this._currentDataImageIndex = index;

            this.View.CurrentDataImage = dataImage;

            SetMoveButtonsEnabledStatus();
        }

        private void SetMoveButtonsEnabledStatus()
        {
            int count = CentoCore.Instance.DataImageCount;

            if(count == 1)
            {
                this.View.FirstDataImageEnabled = false;
                this.View.PreviousDataImageEnabled = false;
                this.View.NextDataImageEnabled = false;
                this.View.LastDataImageEnabled = false;
            }
            else
            {
                // right hand edge
                if (this._currentDataImageIndex > 0 && this._currentDataImageIndex == count - 1)
                {
                    this.View.FirstDataImageEnabled = true;
                    this.View.PreviousDataImageEnabled = true;
                    this.View.NextDataImageEnabled = false;
                    this.View.LastDataImageEnabled = false;
                }
                else if (this._currentDataImageIndex == 0) // left hand edge
                {
                    this.View.FirstDataImageEnabled = false;
                    this.View.PreviousDataImageEnabled = false;
                    this.View.NextDataImageEnabled = true;
                    this.View.LastDataImageEnabled = true;
                }
                else // in the middle
                {
                    this.View.FirstDataImageEnabled = true;
                    this.View.PreviousDataImageEnabled = true;
                    this.View.NextDataImageEnabled = true;
                    this.View.LastDataImageEnabled = true;
                }
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

        void Instance_ProjectOpened(object sender, EventArgs e)
        {
            _currentDataImageIndex = 0;

            this.InitProjectView();
        }

        void Actions_OpenProject(object sender, OpenProjectEventArgs e)
        {
            if(!CentoCore.Instance.OpenProject(e.ProjectFilename))
            {
                this.View.DisplayErrorMessage("Error", "Failed to open project file.");
            }
        }

        void Actions_NextDataImage(object sender, EventArgs e)
        {
            SetCurrentDataImage(this._currentDataImageIndex + 1);
        }

        void Actions_LastDataImage(object sender, EventArgs e)
        {
            SetCurrentDataImage(CentoCore.Instance.DataImageCount - 1);
        }

        void Actions_PreviousDataImage(object sender, EventArgs e)
        {
            SetCurrentDataImage(this._currentDataImageIndex - 1);
        }

        void Actions_FirstDataImage(object sender, EventArgs e)
        {
            SetCurrentDataImage(0);
        }

        void Actions_SelectDataImageIndexChanged(object sender, SelectDataImageIndexChangedEventArgs e)
        {
            SetCurrentDataImage(e.Index);
        }

        #endregion
    }
}
