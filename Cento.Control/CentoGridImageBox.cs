using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Control
{
    public class CentoGridImageBox : CentoImageBox
    {
        #region Members

        private bool _displayGrid = false;
        private int _gridSpacing = 128;

        #endregion

        #region Properties

        public bool DisplayGrid
        {
            get
            {
                return this._displayGrid;
            }
            set
            {
                if(value != this._displayGrid)
                {
                    this._displayGrid = value;
                    this.Invalidate();
                }
            }
        }

        public int GridSpacing
        {
            get
            {
                return this._gridSpacing;
            }
            set
            {
                if(value != this._gridSpacing && value > 0)
                {
                    this._gridSpacing = value;
                    this.Invalidate();
                }
            }
        }

        #endregion

        #region Methods

        private void DrawGrid(Graphics g, Pen p)
        {
            if (this.Image != null)
            {
                int numCellsX = (int)(base.Image.Width / this.GridSpacing);
                int numCellsY = (int)(base.Image.Height / this.GridSpacing);

                for (int i = 1; i < numCellsX; ++i)
                {
                    g.DrawLine(p, i * this.GridSpacing, 0, i * this.GridSpacing, numCellsX * this.GridSpacing);
                }

                for (int i = 1; i < numCellsY; ++i)
                {
                    g.DrawLine(p, 0, i * this.GridSpacing, numCellsX * this.GridSpacing, i * this.GridSpacing);
                }
            }
        }

        #endregion

        #region Overrides

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.DisplayGrid)
            {
                using (Pen p = new Pen(Color.DarkGray))
                {
                    e.Graphics.ScaleTransform(base.ImageScale, base.ImageScale);
                    this.DrawGrid(e.Graphics, p);
                }
            }
        }

        #endregion
    }
}
