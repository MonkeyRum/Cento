using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.Project
{
    public sealed class CentoCore
    {
        #region Members

        private static volatile CentoCore instance;
        private static object syncRoot = new Object();
        private CentoProject _project = new CentoProject();

        private List<CentoProjectDataImage> _dataImages
            = new List<CentoProjectDataImage>();

        public static CentoCore Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CentoCore();
                    }
                }

                return instance;
            }
        }

        #endregion

        #region Events

        public event EventHandler ProjectOpened;

        #endregion

        #region Constructors

        private CentoCore() { }

        #endregion

        #region Properties

        public string ProjectFilename
        {
            get;
            private set;
        }

        public string ProjectFolderPath
        {
            get
            {
                return Path.GetDirectoryName(this.ProjectFilename);
            }
        }

        public int DataImageCount
        {
            get
            {
                return this._dataImages.Count;
            }
        }

        #endregion

        #region Methods

        private void OnProjectOpened()
        {
            var cpy = this.ProjectOpened;
            if(cpy != null)
            {
                cpy(this, EventArgs.Empty);
            }
        }

        public bool OpenProject(string projectFilename)
        {
            this._project = CentoCoreHelpers.LoadProject(projectFilename);

            if (this._project != null)
            {
                this.ProjectFilename = projectFilename;

                this._dataImages.Clear();
                foreach(var dataImage in this._project.DataImage)
                {
                    this._dataImages.Add(dataImage);
                }

                OnProjectOpened();
                return this._project != null;
            }

            return this._project != null;
        }

        public IEnumerable<CentoProjectDataImage> DataImages()
        {
            foreach (var dataImage in this._dataImages)
            {
                yield return dataImage;
            }
        }

        public CentoProjectDataImage GetDataImageFromIndex(int index)
        {
            return this._dataImages[index];
        }

        #endregion
    }
}
