using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Control
{
    public class CellClickedEventArgs : EventArgs
    {
        public Point Cell
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Grid overlay and interactive mouse control of a <see cref="CentoImageBox"/>.
    /// </summary>
    public class CentoGridImageBox : CentoImageBox
    {
        #region Members

        private bool _displayGrid = false;
        private int _gridSpacing = 128;

        private Point? _currentMouseCell = null;

        #endregion

        #region Events

        public event EventHandler<CellClickedEventArgs> CellClicked;

        #endregion

        #region Properties

        /// <summary>
        /// Whether or not to display the grid over the image.
        /// </summary>
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

        /// <summary>
        /// Spacing of the grid in pixels relative to the original Image size.
        /// </summary>
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

        /// <summary>
        /// Draws the grid overlay on the image.
        /// </summary>
        /// <param name="g">Graphics object to draw to.</param>
        /// <param name="p">Pen to draw the grid lines with.</param>
        private void DrawGrid(Graphics g, Pen p)
        {
            if (this.Image != null)
            {
                g.ScaleTransform(base.ImageScale, base.ImageScale);

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

                g.ResetTransform();
            }
        }

        /// <summary>
        /// Draws a highlighted cell.
        /// </summary>
        /// <param name="cell">Cell to highlight.</param>
        /// <param name="g">Graphics object to draw to.</param>
        /// <param name="b">Brush to draw the highlight with.</param>
        private void DrawHighlightCell(Point cell, Graphics g, Brush b)
        {
            if (this.Image != null)
            {
                g.ScaleTransform(base.ImageScale, base.ImageScale);
                g.FillRectangle(b, new Rectangle(cell.X * this.GridSpacing, cell.Y * this.GridSpacing, this.GridSpacing, this.GridSpacing));
                g.ResetTransform();
            }
        }

        /// <summary>
        /// Gets the cell at a specific point specified in control coordinates.
        /// </summary>
        /// <param name="controlPoint">The point to transform in control coordinates.</param>
        /// <returns>The cell the point translates to.</returns>
        private Point? CellFromControlPoint(Point controlPoint)
        {
            Point? cell = null;

            if (base.Image != null)
            {
                int xCell, yCell;

                float displayedWidth = base.Image.Width * base.ImageScale;
                float displayedHeight = base.Image.Height * base.ImageScale;

                int numCellsX = base.Image.Width / this.GridSpacing;
                float cellWidth = displayedWidth / numCellsX;
                xCell = (int)(controlPoint.X / cellWidth);

                int numCellsY = base.Image.Height / this.GridSpacing;
                float cellHeight = displayedHeight / numCellsY;
                yCell = (int)(controlPoint.Y / cellHeight);

                cell = new Point(xCell, yCell);
            }

            return cell;
        }

        #endregion

        #region Virtual Methods

        /// <summary>
        /// Raises CellClicked.
        /// </summary>
        /// <param name="cell">The index of the cell within the Image.</param>
        protected virtual void OnCellClicked(Point cell)
        {
            var cpy = this.CellClicked;
            if(cpy != null)
            {
                this.CellClicked(this, new CellClickedEventArgs { Cell = cell });
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
                    this.DrawGrid(e.Graphics, p);
                }
            }

            if (this._currentMouseCell != null && this._currentMouseCell.HasValue)
            {
                Point cell = this._currentMouseCell.Value;

                using(Brush b = new SolidBrush(Color.FromArgb(128, Color.DarkGray)))
                {
                    DrawHighlightCell(cell, e.Graphics, b);
                }
            }
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            Point? previousCell = _currentMouseCell;
            _currentMouseCell = CellFromControlPoint(new Point(e.X, e.Y));

            if (previousCell != _currentMouseCell)
            {
                this.Invalidate();
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this._currentMouseCell = null;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            Point? cell = CellFromControlPoint(new Point(e.X, e.Y));

            if(cell.HasValue)
            {
                this.OnCellClicked(cell.Value);
            }

            base.OnMouseClick(e);
        }

        #endregion
    }
}
