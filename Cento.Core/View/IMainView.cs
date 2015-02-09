using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.View
{
    public interface IMainView : IView
    {
        IMainViewActions Actions { get; }

        string ProjectFilename { get; set; }

        CentoProjectDataImage CurrentDataImage { get; set; }

        List<CentoProjectDataImage> DataImageList { get; set; }

        bool FirstDataImageEnabled { get; set; }

        bool PreviousDataImageEnabled { get; set; }

        bool NextDataImageEnabled { get; set; }

        bool LastDataImageEnabled { get; set; }

        bool DisplayGrid { get; set; }

        bool DisplayClassification { get; set; }
    }
}
