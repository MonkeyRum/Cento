using Cento.Core.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.View.Actions
{
    public class MainViewActions : IMainViewActions
    {
        #region Events

        public event EventHandler<OpenProjectEventArgs> OpenProject;

        public event EventHandler FirstDataImage;

        public event EventHandler PreviousDataImage;

        public event EventHandler NextDataImage;

        public event EventHandler LastDataImage;

        public event EventHandler<SelectDataImageEventArgs> SelectDataImage;

        public event EventHandler ToggleDisplayGrid;

        public event EventHandler ToggleDisplayClassification;

        public event EventHandler Exit;

        #endregion

        #region Methods

        public void OnOpenProject(string filename)
        {
            var cpy = this.OpenProject;
            if(cpy != null)
            {
                this.OpenProject(this, new OpenProjectEventArgs { ProjectFilename = filename });
            }
        }

        public void OnFirstDataImage()
        {
            var cpy = this.FirstDataImage;
            if (cpy != null)
            {
                this.FirstDataImage(this, EventArgs.Empty);
            }
        }

        public void OnPreviousDataImage()
        {
            var cpy = this.PreviousDataImage;
            if (cpy != null)
            {
                this.PreviousDataImage(this, EventArgs.Empty);
            }
        }

        public void OnNextDataImage()
        {
            var cpy = this.NextDataImage;
            if (cpy != null)
            {
                this.NextDataImage(this, EventArgs.Empty);
            }
        }

        public void OnLastDataImage()
        {
            var cpy = this.LastDataImage;
            if (cpy != null)
            {
                this.LastDataImage(this, EventArgs.Empty);
            }
        }

        public void OnSelectDataImage(string dataImageId)
        {
            var cpy = this.SelectDataImage;
            if (cpy != null)
            {
                this.SelectDataImage(this, new SelectDataImageEventArgs { DataImageId = dataImageId });
            }
        }

        public void OnToggleDisplayGrid()
        {
            var cpy = this.ToggleDisplayGrid;
            if (cpy != null)
            {
                this.ToggleDisplayGrid(this, EventArgs.Empty);
            }
        }

        public void OnToggleDisplayClassification()
        {
            var cpy = this.ToggleDisplayClassification;
            if (cpy != null)
            {
                this.ToggleDisplayClassification(this, EventArgs.Empty);
            }
        }

        public void OnExit()
        {
            var cpy = this.Exit;
            if (cpy != null)
            {
                this.Exit(this, EventArgs.Empty);
            }
        }

        #endregion
    }
}
