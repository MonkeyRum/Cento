using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cento.Control
{
    /// <summary>
    /// Control for displaying an image with a grid overlay.
    /// Can return grid index on mouse click.
    /// </summary>
    public partial class GridImageBox : UserControl
    {
        #region Members

        private readonly Point ORIGIN = new Point(0, 0);

        private Image _image = null;
        private float _imageScale = 1.0f;
        private bool _scaleToFit = false;

        #endregion

        #region Constructors

        public GridImageBox()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.ResizeRedraw | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);

            // TEMP
            this.Image = Image.FromFile(@"F:\backup\Pictures\Imagedataset\IMG_5097.JPG");

            // Set false in member declare and true here to force scale update
            this.ScaleToFit = true;
        }

        #endregion

        #region Properties

        [DefaultValue(typeof(Image), null)]
        public Image Image
        {
            get
            {
                return this._image;
            }
            set
            {
                if (!ReferenceEquals(value, this._image))
                {
                    this._image = value;
                    this.Invalidate();
                }
            }
        }

        [DefaultValue(typeof(float), "1.0f")]
        public float ImageScale
        {
            get
            {
                return this._imageScale;
            }
            set
            {
                if (value > 0.0)
                {
                    this._imageScale = value;
                }
            }
        }

        [DefaultValue(typeof(bool), "true")]
        public bool ScaleToFit
        {
            get
            {
                return this._scaleToFit;
            }
            set
            {
                if (value != this._scaleToFit)
                {
                    this._scaleToFit = value;
                    this.ScaleToFitImpl();
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Scales the image to fit within the bounds of the control.
        /// Will fire a ScaleChanged event if the scale has changed.
        /// </summary>
        private void ScaleToFitImpl()
        {
            // image dimensions
            int iw = this.Image.Width;
            int ih = this.Image.Height;

            // control dimensions
            int cw = this.Width;
            int ch = this.Height;

            // scale factors
            float sw = (float)cw / iw;
            float sh = (float)ch / ih;

            this.ImageScale = sw <= sh ? sw : sh;
        }

        #endregion

        #region Overrides

        protected override void OnResize(EventArgs e)
        {
            if (this.ScaleToFit)
            {
                this.ScaleToFitImpl();
            }

            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;

            if (this.Image != null)
            {
                g.ResetTransform();
                g.ScaleTransform(this.ImageScale * 2, this.ImageScale * 2);
                g.DrawImage(this.Image, ORIGIN);
            }
        }

        #endregion
    }
}
