using Cento.Core.Project;
using Cento.Core.View;
using Cento.View.Actions;
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
    public partial class MainView : ViewBase, IMainView
    {
        #region Members

        private const string _TITLE = "Cento";
        private string _projectFilename = String.Empty;
        private CentoProjectDataImage _currentDataImage = null;
        private List<CentoProjectDataImage> _dataImageIdList = null;

        private IMainViewActions _actions = null;

        #endregion

        #region Constructors

        public MainView()
        {
            InitializeComponent();

            this.Actions = new MainViewActions();
            this.cmbImageFiles.ComboBox.DisplayMember = "Id";
        }

        #endregion

        #region Properties

        public bool DisplayGrid
        {
            get
            {
                return this.gridToolStripMenuItem.Checked;
            }
            set
            {
                if (value != this.gridToolStripMenuItem.Checked)
                {
                    this.gridToolStripMenuItem.Checked = value;
                    this.centoGridImageBox1.DisplayGrid = value;
                }
            }
        }

        public bool DisplayClassification
        {
            get
            {
                return this.classificationToolStripMenuItem.Checked;
            }
            set
            {
                if (value != this.classificationToolStripMenuItem.Checked)
                {
                    this.classificationToolStripMenuItem.Checked = value;
                    this.centoGridImageBox1.DisplayClassification = value;
                }
            }
        }

        public IMainViewActions Actions
        {
            get
            {
                return this._actions;
            }
            private set
            {
                this._actions = value;
            }
        }

        public string ProjectFilename
        {
            get
            {
                return this._projectFilename;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    this.Text = value;
                }
                else
                {
                    this.Text = _TITLE + " - " + Path.GetFileName(value);
                }
            }
        }

        public CentoProjectDataImage CurrentDataImage
        {
            get
            {
                return this._currentDataImage;
            }
            set
            {
                if (!ReferenceEquals(this._currentDataImage, value))
                {
                    this._currentDataImage = value;
                    this.centoGridImageBox1.Image = value.Image;
                    this.cmbImageFiles.ComboBox.SelectedItem = value;
                    this.propertyGrid1.SelectedObject = value;
                }
            }
        }

        public List<CentoProjectDataImage> DataImageList
        {
            get
            {
                return this._dataImageIdList;
            }
            set
            {
                this._dataImageIdList = value;

                if(value != null)
                {
                    foreach(var dataImage in value)
                    {
                        this.cmbImageFiles.Items.Add(dataImage);
                    }
                }
            }
        }

        public bool FirstDataImageEnabled
        {
            get
            {
                return this.tlBtnFirst.Enabled;
            }
            set
            {
                this.tlBtnFirst.Enabled = value;
            }
        }

        public bool PreviousDataImageEnabled
        {
            get
            {
                return this.tlBtnPrevious.Enabled;
            }
            set
            {
                this.tlBtnPrevious.Enabled = value;
            }
        }

        public bool NextDataImageEnabled
        {
            get
            {
                return this.tlBtnNext.Enabled;
            }
            set
            {
                this.tlBtnNext.Enabled = value;
            }
        }

        public bool LastDataImageEnabled
        {
            get
            {
                return this.tlBtnLast.Enabled;
            }
            set
            {
                this.tlBtnLast.Enabled = value;
            }
        }

        #endregion

        #region Methods

        private MainViewActions GetActions()
        {
            var actions = this.Actions as MainViewActions;

            if(actions != null)
            {
                return actions;
            }

            throw new InvalidOperationException("Failed to retrieve actions for MainView");
        }

        private void OpenProjectFileAction()
        {
            if (this.openProjectFileDialog.ShowDialog() == DialogResult.OK)
            {
                var actions = this.GetActions();
                actions.OnOpenProject(this.openProjectFileDialog.FileName);
            }
        }

        #endregion

        #region EventHandlers

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProjectFileAction();
        }

        private void tlBtnOpenProject_Click(object sender, EventArgs e)
        {
            OpenProjectFileAction();
        }

        private void tlBtnFirst_Click(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnFirstDataImage();
        }

        private void tlBtnPrevious_Click(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnPreviousDataImage();
        }

        private void tlBtnNext_Click(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnNextDataImage();
        }

        private void tlBtnLast_Click(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnLastDataImage();
        }

        private void cmbImageFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnSelectDataImageIndexChanged(this.cmbImageFiles.SelectedIndex);
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnToggleDisplayGrid();
        }

        private void classificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actions = this.GetActions();
            actions.OnToggleDisplayClassification();
        }

        #endregion
    }
}
