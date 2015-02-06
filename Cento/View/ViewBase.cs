using Cento.Core.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cento.View
{
    public partial class ViewBase : Form, IView
    {
        #region Constructors

        public ViewBase()
        {
            InitializeComponent();
        }

        #endregion

        #region IView

        public void DisplayErrorMessage(string caption, string description)
        {
            MessageBox.Show(description, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
