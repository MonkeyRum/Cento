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
    public partial class CentoImageBox : UserControl
    {
        #region Members

        private readonly Point ORIGIN = new Point(0, 0);

        private Image _image = null;
        private float _imageScale = 1.0f;
        private bool _scaleToFit = false;

        #endregion

        #region Constructors

        public CentoImageBox()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.ResizeRedraw | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint, true);

            // TEMP
            //this.Image = Image.FromFile(@"F:\backup\Pictures\Imagedataset\IMG_5097.JPG");

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
            if (this.Image != null)
            {
                // image dimensions
                int iw = this.Image.Width;
                int ih = this.Image.Height;

                // control dimensions
                int cw = this.ClientRectangle.Width;
                int ch = this.ClientRectangle.Height;

                // scale factors
                float sw = (float)cw / iw;
                float sh = (float)ch / ih;

                this.ImageScale = sw < sh ? sw : sh;
            }
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
                int newWidth = (int)(this.Image.Width * this.ImageScale);
                int newHeight = (int)(this.Image.Height * this.ImageScale);

                g.Clip = new Region(new Rectangle(0, 0, newWidth, newHeight));

                g.DrawImage(this.Image, 0, 0, newWidth, newHeight);
            }
        }

        #endregion
    }
}
