using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.Project
{
    public sealed class TheProject
    {
        private static volatile TheProject instance;
        private static object syncRoot = new Object();
        private CentoProject _project = new CentoProject();

        private ObservableCollection<CentoProjectDataImage> _dataImages 
            = new ObservableCollection<CentoProjectDataImage>();

        private TheProject() { }

        public static TheProject Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TheProject();
                    }
                }

                return instance;
            }
        }

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

                    foreach(var dataImage in this._project.DataImage)
                    {
                        this.DataImages.Add(dataImage);
                    }
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
    }
}
