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
    public class DarkGroupBox : GroupBox
    {
        private Color backColor = Color.FromArgb(40, 43, 45);
        private Color borderColor = Color.FromArgb(60, 63, 65);
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

        public DarkGroupBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint, true);

            ResizeRedraw = true;
            DoubleBuffered = true;
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
            var g = e.Graphics;
            var rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            var stringSize = g.MeasureString(Text, Font);

            var textColor = this.ForeColor;
            var fillColor = this.BackColor;

            using (var b = new SolidBrush(fillColor))
            {
                g.FillRectangle(b, rect);
            }

            using (var p = new Pen(BorderColor, 1))
            {
                var borderRect = new Rectangle(0, (int)stringSize.Height / 2, rect.Width - 1, rect.Height - ((int)stringSize.Height / 2) - 1);
                GraphicsPath graphPath = GetRoundPath(borderRect, this.BorderRadius);
                // g.DrawRectangle(p, borderRect);
                g.DrawPath(p, graphPath);
            }

            var textRect = new Rectangle(rect.Left + this.Padding.Left,
                    rect.Top,
                    rect.Width - (this.Padding.Horizontal),
                    (int)stringSize.Height);

            using (var b2 = new SolidBrush(fillColor))
            {
                var modRect = new Rectangle(textRect.Left, textRect.Top, Math.Min(textRect.Width, (int)stringSize.Width), textRect.Height);
                g.FillRectangle(b2, modRect);
            }

            using (var b = new SolidBrush(textColor))
            {
                var stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                g.DrawString(Text, Font, b, textRect, stringFormat);
            }
        }
    }    
}
