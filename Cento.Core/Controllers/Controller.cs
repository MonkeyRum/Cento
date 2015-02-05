using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.Controllers
{
    public abstract class Controller : IController
    {
        #region Properties

        public abstract void ShowView();

        #endregion
    }
}
