using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.View
{
    public class ProjectOpenedEventArgs : EventArgs
    {
        public string Filename
        {
            get;
            set;
        }
    }

    public interface IMainView : IView
    {
        string ProjectFilename { get; set; }
        Image CurrentImage { get; set; }

        event EventHandler<ProjectOpenedEventArgs> ProjectOpened;
    }
}
