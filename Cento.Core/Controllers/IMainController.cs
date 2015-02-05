using Cento.Core.View;
using System;
namespace Cento.Core.Controllers
{
    public interface IMainController
    {
        IMainView View { get; }
        bool OpenProject(string filename);
    }
}
