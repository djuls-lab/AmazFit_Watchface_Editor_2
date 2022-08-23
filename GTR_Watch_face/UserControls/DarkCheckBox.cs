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
    public class DarkCheckBox : CheckBox
    {
        private Color _backColor = Color.DodgerBlue;
        private Color _borderColor = Color.Gainsboro;
        private int _borderRadius = 2;
        private int _borderThickness = 2;
        private int _imagePadding = 5;
        private bool _useVisualStyleBackColor = false;


        #region <Appearance> (Properties)

        [Category("Appearance")]
        [Description("The Border Color.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(typeof(Color), "DimGray")]
        public Color BorderColor
        { 
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The Border Radius.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(4)]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The Border Thickness.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(1.0F)]
        public int BorderThickness
        {
            get { return _borderThickness; }
            set { _borderThickness = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Determines the amount of padding between the image and text.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(5)]
        public int ImagePadding
        {
            get { return _imagePadding; }
            set { _imagePadding = value; Invalidate(); }
        }

        new public Color BackColor
        {
            get { return _backColor; }
            set { _backColor = value; Invalidate(); }
        }

        new public bool UseVisualStyleBackColor
        {
            get { return _useVisualStyleBackColor; }
            set { _useVisualStyleBackColor = value; Invalidate(); }
        }

        #endregion

        public DarkCheckBox()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint, true);

            ResizeRedraw = true;
            DoubleBuffered = true;
            //BackColor = Color.FromArgb(64, 64, 64);
        }

        GraphicsPath GetRoundPath(RectangleF bounds, int radius)
        {
            int diameter = radius * 2;
            SizeF size = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(bounds.Location, size);
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

            var size = 12;

            var textColor = ForeColor;
            var borderColor = BorderColor;
            var fillColor = BackColor;

            if (Enabled)
            {
                /*if (Focused)
                {
                    borderColor = Colors.BlueHighlight;
                    fillColor = Colors.BlueSelection;
                }

                if (_controlState == DarkControlState.Hover)
                {
                    borderColor = Colors.BlueHighlight;
                    fillColor = Colors.BlueSelection;
                }
                else if (_controlState == DarkControlState.Pressed)
                {
                    borderColor = Colors.GreyHighlight;
                    fillColor = Colors.GreySelection;
                }*/
            }
            else
            {
                textColor = Color.DimGray;
                borderColor = Color.Gray;
                fillColor = Color.DimGray;
            }

            using (var b = new SolidBrush(Parent.BackColor))
            {
                g.FillRectangle(b, rect);
            }

            g.SmoothingMode = SmoothingMode.HighQuality;

            var boxRect = new Rectangle(0, (rect.Height / 2) - (size / 2), size, size);

            GraphicsPath path;

            using (var pen = new Pen(borderColor, BorderThickness))
            {
                path = GetRoundPath(boxRect, BorderRadius);
                g.DrawPath(pen, path);
            }

            if (Checked)
            {
                using (var brush = new SolidBrush(fillColor))
                {
                    boxRect.Inflate(-BorderThickness - 1, -BorderThickness - 1);
                    path = GetRoundPath(boxRect, BorderRadius / 2);
                    g.FillPath(brush, path);
                }
            }

            using (var b = new SolidBrush(textColor))
            {
                var stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                };

                var modRect = new Rectangle(size + 4, 0, rect.Width - size, rect.Height);
                g.DrawString(Text, Font, b, modRect, stringFormat);
            }
        }
    }    
}
