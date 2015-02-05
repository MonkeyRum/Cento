using System;
using System.Collections.Generic;
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
        string Filename { get; set; }

        event EventHandler<ProjectOpenedEventArgs> ProjectOpened;
    }
}
