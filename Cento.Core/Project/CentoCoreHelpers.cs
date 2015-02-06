using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Cento.Core.Project
{
    public static class CentoCoreHelpers
    {
        public static CentoProject LoadProject(string filename)
        {
            CentoProject project = null;

            if (!String.IsNullOrWhiteSpace(filename))
            {
                if (File.Exists(filename) && File.Exists("CentoProj.xsd"))
                {
                    if (IsValidXml(filename, "CentoProj.xsd"))
                    {
                        System.Xml.Serialization.XmlSerializer reader =
                            new System.Xml.Serialization.XmlSerializer(typeof(CentoProject));

                        System.IO.StreamReader file = new System.IO.StreamReader(filename);
                        project = (CentoProject)reader.Deserialize(file);
                    }
                }
            }

            return project;
        }

        private static bool IsValidXml(string xmlFilePath, string xsdFilePath)
        {
            var xdoc = XDocument.Load(xmlFilePath);
            var schemas = new XmlSchemaSet();
            schemas.Add(null, xsdFilePath);

            try
            {
                xdoc.Validate(schemas, null);
            }
            catch (XmlSchemaValidationException)
            {
                return false;
            }

            return true;
        }
    }
}
