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
    public class DarkButton : Button
    {
        private Color _backColor = Color.FromArgb(64, 64, 64);
        private Color _borderColor = Color.DimGray;
        private int _borderRadius = 4;
        private float _borderThickness = 1.0F;
        private int _imagePadding = 5;


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
        public float BorderThickness
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

        #endregion

        public DarkButton()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint, true);

            ResizeRedraw = true;
            DoubleBuffered = true;
            //BackColor = Color.FromArgb(64, 64, 64);
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

            var g = e.Graphics;

            // Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            var rect = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            GraphicsPath graphPath = GetRoundPath(rect, BorderRadius);

            // Region = new Region(graphPath);

            g.Clear(Parent.BackColor);

            /*using (var b = new SolidBrush(Parent.BackColor))
            {
                g.FillRectangle(b, rect);
            }*/

            using (Brush brush = new SolidBrush(BackColor))
            {
                g.FillPath(brush, graphPath);
            }

            g.SmoothingMode = SmoothingMode.HighQuality;

            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                // pen.Alignment = PenAlignment.Inset;
                g.DrawPath(pen, graphPath);
            }

            /*StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            
            string text = Text;
            if (text.Length == 0 || Width == 0) return;
            int i = text.Length;
            while (TextRenderer.MeasureText(text + "...", Font).Width > Width - Margin.Horizontal)
            {
                text = Text.Substring(0, --i);
                if (i == 0) break;
            }
            text = text + "...";*/

            /*if (Image != null)
            {
                Size imageSize = Image.Size;
                g.DrawImage(Image, (Width - imageSize.Width) / 2.0F, (Height - imageSize.Height) / 2.0F);
            }*/

            var textOffsetX = 0;
            var textOffsetY = 0;

            if (Image != null)
            {
                var stringSize = g.MeasureString(Text, Font, rect.Size);

                var x = (ClientSize.Width / 2) - (Image.Size.Width / 2);
                var y = (ClientSize.Height / 2) - (Image.Size.Height / 2);

                var padding = ImagePadding;
                /*if (Text == String.Empty)
                {
                    padding = 0;
                }*/

                switch (TextImageRelation)
                {
                    case TextImageRelation.ImageAboveText:
                        textOffsetY = (Image.Size.Height / 2) + (padding / 2);
                        y = y - ((int)(stringSize.Height / 2) + (padding / 2));
                        break;
                    case TextImageRelation.TextAboveImage:
                        textOffsetY = ((Image.Size.Height / 2) + (padding / 2)) * -1;
                        y = y + ((int)(stringSize.Height / 2) + (padding / 2));
                        break;
                    case TextImageRelation.ImageBeforeText:
                        textOffsetX = Image.Size.Width + (padding * 2);
                        x = padding;
                        break;
                    case TextImageRelation.TextBeforeImage:
                        x = x + (int)stringSize.Width;
                        break;
                }

                g.DrawImageUnscaled(Image, x, y);
            }

            /*using (Brush brush = new SolidBrush(ForeColor))
            {
                g.DrawString(text, Font, brush, rect, stringFormat);
            }*/

            using (var b = new SolidBrush(ForeColor))
            {
                var modRect = new Rectangle(rect.Left + textOffsetX + Padding.Left,
                                            rect.Top + textOffsetY + Padding.Top, rect.Width - Padding.Horizontal,
                                            rect.Height - Padding.Vertical);

                var stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                g.DrawString(Text, Font, b, modRect, stringFormat);
            }
        }
    }    
}
