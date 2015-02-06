using Cento.Core.Project;
using Cento.Core.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cento.View
{
    public partial class MainView : Form, IMainView
    {
        #region Members

        private string _filename = String.Empty;

        private OpenFileDialog _openProjectFileDialog = new OpenFileDialog
        {
            DefaultExt = "cproj",
            Filter = "Cento project files (*.cproj)|*.cproj"
        };

        private float _zoomLevel;

        #endregion

        #region Events

        public event EventHandler<ProjectOpenedEventArgs> ProjectOpened;

        #endregion

        #region Constructors

        public MainView()
        {
            InitializeComponent();

            this.centoGridImageBox1.ScaleChanged += centoGridImageBox1_ScaleChanged;
        }

        #endregion

        #region Properties

        public Image CurrentImage
        {
            get
            {
                return centoGridImageBox1.Image;
            }
            set
            {
                centoGridImageBox1.Image = value;
            }
        }

        public float ZoomLevel
        {
            get
            {
                return _zoomLevel;
            }
            private set
            {
                this._zoomLevel = value;

                this.stsZoom.Text = "Zoom " + value.ToString("0.##%");
            }
        }

        public string ProjectFilename
        {
            get
            {
                return this._filename;
            }
            set
            {
                this._filename = value;
                this.Text = "Cento - " + Path.GetFileName(value);
            }
        }

        #endregion

        #region Methods

        public void DisplayErrorMessage(string caption, string description)
        {
            MessageBox.Show(description, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Event Handlers

        void centoGridImageBox1_ScaleChanged(object sender, EventArgs e)
        {
            this.ZoomLevel = this.centoGridImageBox1.ImageScale;
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.OnProjectOpened(new ProjectOpenedEventArgs { ProjectFilename = _openProjectFileDialog.FileName });
            }
        }

        private void tlBtnOpenProject_Click(object sender, EventArgs e)
        {
            openProjectToolStripMenuItem_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
        }

        #endregion

        #region Virtual Methods

        protected virtual void OnProjectOpened(ProjectOpenedEventArgs e)
        {
            EventHandler<ProjectOpenedEventArgs> handler = ProjectOpened;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion
    }
}
