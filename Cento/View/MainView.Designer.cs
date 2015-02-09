namespace Cento.View
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.openProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.centoGridImageBox1 = new Cento.Control.CentoGridImageBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlBtnOpenProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tlBtnPrevious = new System.Windows.Forms.ToolStripButton();
            this.tlBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tlBtnLast = new System.Windows.Forms.ToolStripButton();
            this.tlBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbImageFiles = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openProjectFileDialog
            // 
            this.openProjectFileDialog.DefaultExt = "cproj";
            this.openProjectFileDialog.FileName = "openFileDialog1";
            this.openProjectFileDialog.Filter = "Cento Project Files|*.cproj";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.centoGridImageBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(624, 366);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 4;
            // 
            // centoGridImageBox1
            // 
            this.centoGridImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centoGridImageBox1.DisplayClassification = true;
            this.centoGridImageBox1.DisplayGrid = true;
            this.centoGridImageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centoGridImageBox1.GridSpacing = 128;
            this.centoGridImageBox1.ImageScale = 1F;
            this.centoGridImageBox1.Location = new System.Drawing.Point(0, 0);
            this.centoGridImageBox1.Name = "centoGridImageBox1";
            this.centoGridImageBox1.Size = new System.Drawing.Size(420, 366);
            this.centoGridImageBox1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(200, 366);
            this.propertyGrid1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlBtnOpenProject,
            this.toolStripSeparator2,
            this.tlBtnFirst,
            this.tlBtnPrevious,
            this.tlBtnNext,
            this.tlBtnLast,
            this.tlBtnExit,
            this.toolStripSeparator3,
            this.cmbImageFiles,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 29);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlBtnOpenProject
            // 
            this.tlBtnOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnOpenProject.Image")));
            this.tlBtnOpenProject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnOpenProject.Name = "tlBtnOpenProject";
            this.tlBtnOpenProject.Size = new System.Drawing.Size(26, 26);
            this.tlBtnOpenProject.Text = "toolStripButton5";
            this.tlBtnOpenProject.ToolTipText = "Open project";
            this.tlBtnOpenProject.Click += new System.EventHandler(this.tlBtnOpenProject_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tlBtnFirst
            // 
            this.tlBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnFirst.Enabled = false;
            this.tlBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnFirst.Image")));
            this.tlBtnFirst.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnFirst.Name = "tlBtnFirst";
            this.tlBtnFirst.Size = new System.Drawing.Size(26, 26);
            this.tlBtnFirst.Text = "toolStripButton1";
            this.tlBtnFirst.ToolTipText = "First image";
            this.tlBtnFirst.Click += new System.EventHandler(this.tlBtnFirst_Click);
            // 
            // tlBtnPrevious
            // 
            this.tlBtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnPrevious.Enabled = false;
            this.tlBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnPrevious.Image")));
            this.tlBtnPrevious.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnPrevious.Name = "tlBtnPrevious";
            this.tlBtnPrevious.Size = new System.Drawing.Size(26, 26);
            this.tlBtnPrevious.Text = "toolStripButton2";
            this.tlBtnPrevious.ToolTipText = "Previous image";
            this.tlBtnPrevious.Click += new System.EventHandler(this.tlBtnPrevious_Click);
            // 
            // tlBtnNext
            // 
            this.tlBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnNext.Enabled = false;
            this.tlBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnNext.Image")));
            this.tlBtnNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnNext.Name = "tlBtnNext";
            this.tlBtnNext.Size = new System.Drawing.Size(26, 26);
            this.tlBtnNext.Text = "toolStripButton3";
            this.tlBtnNext.ToolTipText = "Next image";
            this.tlBtnNext.Click += new System.EventHandler(this.tlBtnNext_Click);
            // 
            // tlBtnLast
            // 
            this.tlBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnLast.Enabled = false;
            this.tlBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnLast.Image")));
            this.tlBtnLast.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnLast.Name = "tlBtnLast";
            this.tlBtnLast.Size = new System.Drawing.Size(26, 26);
            this.tlBtnLast.Text = "toolStripButton4";
            this.tlBtnLast.ToolTipText = "Last image";
            this.tlBtnLast.Click += new System.EventHandler(this.tlBtnLast_Click);
            // 
            // tlBtnExit
            // 
            this.tlBtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnExit.Image")));
            this.tlBtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnExit.Name = "tlBtnExit";
            this.tlBtnExit.Size = new System.Drawing.Size(26, 26);
            this.tlBtnExit.Text = "toolStripButton6";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // cmbImageFiles
            // 
            this.cmbImageFiles.Name = "cmbImageFiles";
            this.cmbImageFiles.Size = new System.Drawing.Size(121, 29);
            this.cmbImageFiles.SelectedIndexChanged += new System.EventHandler(this.cmbImageFiles_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsZoom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsZoom
            // 
            this.stsZoom.Name = "stsZoom";
            this.stsZoom.Size = new System.Drawing.Size(58, 17);
            this.stsZoom.Text = "Zoom 0%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openProjectToolStripMenuItem.Image")));
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "&Open project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.classificationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Checked = true;
            this.gridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gridToolStripMenuItem.Text = "&Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // classificationToolStripMenuItem
            // 
            this.classificationToolStripMenuItem.Checked = true;
            this.classificationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.classificationToolStripMenuItem.Name = "classificationToolStripMenuItem";
            this.classificationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.classificationToolStripMenuItem.Text = "&Classification";
            this.classificationToolStripMenuItem.Click += new System.EventHandler(this.classificationToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImageToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "&Project";
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Enabled = false;
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addImageToolStripMenuItem.Text = "&Add Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Cento";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tlBtnFirst;
        private System.Windows.Forms.ToolStripButton tlBtnPrevious;
        private System.Windows.Forms.ToolStripButton tlBtnNext;
        private System.Windows.Forms.ToolStripButton tlBtnLast;
        private System.Windows.Forms.ToolStripButton tlBtnOpenProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlBtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stsZoom;
        private System.Windows.Forms.OpenFileDialog openProjectFileDialog;
        private System.Windows.Forms.ToolStripComboBox cmbImageFiles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Control.CentoGridImageBox centoGridImageBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

