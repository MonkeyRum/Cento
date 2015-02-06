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

        private ObservableCollection<CentoProjectDataImage> _dataImages
            = new ObservableCollection<CentoProjectDataImage>();

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

        public event EventHandler ProjectFilenameChanged;

        #endregion

        #region Constructors

        private CentoCore() { }

        #endregion

        #region Properties

        public bool OpenProject(string filename)
        {
            bool bIsOpenSuccess = false;

            if (!String.IsNullOrWhiteSpace(filename))
            {
                if (File.Exists(filename))
                {
                    // http://stackoverflow.com/questions/751511/validating-an-xml-against-referenced-xsd-in-c-sharp

                    System.Xml.Serialization.XmlSerializer reader =
                        new System.Xml.Serialization.XmlSerializer(typeof(CentoProject));

                    System.IO.StreamReader file = new System.IO.StreamReader(filename);
                    this._project = (CentoProject)reader.Deserialize(file);

                    this.ProjectFilename = filename;

                    foreach(var dataImage in this._project.DataImage)
                    {
                        this.DataImages.Add(dataImage);
                    }

                    bIsOpenSuccess = true;
                }
            }

            return bIsOpenSuccess;
        }

        public ObservableCollection<CentoProjectDataImage> DataImages
        {
            get
            {
                return _dataImages;
            }
            private set
            {
                if (value != null && !ReferenceEquals(value, this._dataImages))
                {
                    this._dataImages = value;
                }
            }
        }

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

        #endregion

        #region Methods

        private void OnProjectFilenameChanged()
        {
            var cpy = this.ProjectFilenameChanged;
            if(cpy != null)
            {
                cpy(this, EventArgs.Empty);
            }
        }

        #endregion
    }
}
