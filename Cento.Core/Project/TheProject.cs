using System;
using System.Collections.Generic;
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

        public static bool OpenProject(string filename)
        {
            bool bIsOpenSuccess = false;

            if (!String.IsNullOrWhiteSpace(filename))
            {
                if (File.Exists(filename))
                {
                    
                }
            }

            return bIsOpenSuccess;
        }
    }
}
