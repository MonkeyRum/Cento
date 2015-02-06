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
        private string _filename = String.Empty;
        private OpenFileDialog _openProjectFileDialog = new OpenFileDialog
            {
                DefaultExt = "cproj",
                Filter = "Cento project files (*.cproj)|*.cproj"
            };

        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler<ProjectOpenedEventArgs> ProjectOpened;

        public void DisplayErrorMessage(string caption, string description)
        {
            MessageBox.Show(description, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected virtual void OnProjectOpened(ProjectOpenedEventArgs e)
        {
            EventHandler<ProjectOpenedEventArgs> handler = ProjectOpened;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.OnProjectOpened(new ProjectOpenedEventArgs { Filename = _openProjectFileDialog.FileName });
            }
        }

        private void tlBtnOpenProject_Click(object sender, EventArgs e)
        {
            openProjectToolStripMenuItem_Click(sender, e);
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
        }


        //public List<string> Filenames
        //{
        //    get
        //    {
        //        return cmbImageFiles.
        //    }
        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
