using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cento.Core.Project;

namespace Cento.Core.Test
{
    [TestClass]
    public class TheProjectTests
    {
        [TestMethod]
        public void ReadValidProjectFile()
        {
            string filename = @"C:\Users\Alex\Documents\GitHub\Cento\Cento.Core.Test\testfiles\centoProjValid.xml";

            CentoCore.Instance.OpenProject(filename);
        }

        [TestMethod]
        public void ReadInvalidProjectFile()
        {
            string filename = @"C:\Users\Alex\Documents\GitHub\Cento\Cento.Core.Test\testfiles\centoProjInvalid.xml";

            CentoCore.Instance.OpenProject(filename);
        }
    }
}
