using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace AmazFit_Watchface_2
{
    class DarkButton : Button
    {
        private Color backColor = Color.FromArgb(64, 64, 64);
        private Color borderColor = Color.DimGray;
        private int borderRadius = 4;
        private float borderThickness = 1.0F;

        #region <Appearance> (Properties)

        [Category("Appearance")]
        [Description("The Border Color.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(typeof(Color), "DimGray")]
        public Color BorderColor
        { 
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The Border Radius.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(4)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The Border Thickness.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(1.0F)]
        public float BorderThickness
        {
            get { return borderThickness; }
            set { borderThickness = value; Invalidate(); }
        }

        public override Color BackColor
        {
            get { return backColor; }
            set { backColor = value; Invalidate(); }
        }

        #endregion

        public DarkButton()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            //this.BackColor = Color.FromArgb(64, 64, 64);
        }

        GraphicsPath GetRoundPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath { FillMode = FillMode.Alternate };

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            // int borderRadius = 6;
            // float borderThickness = 1.0f;

            

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath graphPath = GetRoundPath(rect, this.BorderRadius);

            // this.Region = new Region(graphPath);

            e.Graphics.Clear(this.Parent.BackColor);

            using (Brush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, graphPath);
            }

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            using (Pen pen = new Pen(this.BorderColor, this.BorderThickness))
            {
                // pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, graphPath);
            }

            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            
            string text = this.Text;
            if (text.Length == 0 || this.Width == 0) return;
            int i = text.Length;
            while (TextRenderer.MeasureText(text + "...", this.Font).Width > this.Width - this.Margin.Horizontal)
            {
                text = this.Text.Substring(0, --i);
                if (i == 0) break;
            }
            text = text + "...";

            using (Brush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(text, this.Font, brush, rect, stringFormat);
            }            
        }
    }    
}
