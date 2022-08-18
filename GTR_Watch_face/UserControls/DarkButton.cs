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
        private Color backColor = Color.FromArgb(64, 64, 64);
        private Color borderColor = Color.DimGray;
        private int borderRadius = 4;
        private float borderThickness = 1.0F;
        private int imagePadding = 5;


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

        [Category("Appearance")]
        [Description("Determines the amount of padding between the image and text.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        // [DefaultValue(5)]
        public int ImagePadding
        {
            get { return imagePadding; }
            set { imagePadding = value; Invalidate(); }
        }

        new public Color BackColor
        {
            get { return backColor; }
            set { backColor = value; Invalidate(); }
        }

        #endregion

        public DarkButton()
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
            //base.OnPaint(e);
            // int borderRadius = 6;
            // float borderThickness = 1.0f;

            var g = e.Graphics;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath graphPath = GetRoundPath(rect, this.BorderRadius);

            // this.Region = new Region(graphPath);

            g.Clear(this.Parent.BackColor);

            using (Brush brush = new SolidBrush(this.BackColor))
            {
                g.FillPath(brush, graphPath);
            }

            g.SmoothingMode = SmoothingMode.HighQuality;

            using (Pen pen = new Pen(this.BorderColor, this.BorderThickness))
            {
                // pen.Alignment = PenAlignment.Inset;
                g.DrawPath(pen, graphPath);
            }

            /*StringFormat stringFormat = new StringFormat();
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
            text = text + "...";*/

            /*if (this.Image != null)
            {
                Size imageSize = this.Image.Size;
                g.DrawImage(this.Image, (this.Width - imageSize.Width) / 2.0F, (this.Height - imageSize.Height) / 2.0F);
            }*/

            var textOffsetX = 0;
            var textOffsetY = 0;

            if (Image != null)
            {
                var stringSize = g.MeasureString(Text, Font, rect.Size);

                var x = (ClientSize.Width / 2) - (Image.Size.Width / 2);
                var y = (ClientSize.Height / 2) - (Image.Size.Height / 2);

                var padding = this.ImagePadding;
                /*if (this.Text == String.Empty)
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

            /*using (Brush brush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(text, this.Font, brush, rect, stringFormat);
            }*/

            using (var b = new SolidBrush(this.ForeColor))
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
