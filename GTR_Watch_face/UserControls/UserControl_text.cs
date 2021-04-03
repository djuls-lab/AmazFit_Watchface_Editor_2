﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazFit_Watchface_2
{
    public partial class UserControl_text : UserControl
    {
        private bool setValue;
        public UserControl_text()
        {
            InitializeComponent();
            comboBox_alignment.SelectedIndex = 0;
        }


        internal void comboBoxSetImage(int value)
        {
            comboBox_image.Text = value.ToString();
            if (comboBox_image.SelectedIndex < 0) comboBox_image.Text = "";
        }

        internal int comboBoxGetImage()
        {
            int value = -1;
            Int32.TryParse(comboBox_image.Text, out value);
            return value;
        }

        internal void comboBoxSetIcon(int value)
        {
            comboBox_icon.Text = value.ToString();
            if (comboBox_icon.SelectedIndex < 0) comboBox_icon.Text = "";
        }

        internal int comboBoxGetIcon()
        {
            int value = -1;
            Int32.TryParse(comboBox_icon.Text, out value);
            return value;
        }

        internal void comboBoxSetUnit(int value)
        {
            comboBox_unit.Text = value.ToString();
            if (comboBox_unit.SelectedIndex < 0) comboBox_unit.Text = "";
        }

        internal int comboBoxGetUnit()
        {
            int value = -1;
            Int32.TryParse(comboBox_unit.Text, out value);
            return value;
        }

        internal void comboBoxSetImageError(int value)
        {
            comboBox_imageError.Text = value.ToString();
            if (comboBox_imageError.SelectedIndex < 0) comboBox_imageError.Text = "";
        }

        internal int comboBoxGetImageError()
        {
            int value = -1;
            Int32.TryParse(comboBox_imageError.Text, out value);
            return value;
        }

        internal void comboBoxSetImageDecimalPoint(int value)
        {
            comboBox_imageDecimalPoint.Text = value.ToString();
            if (comboBox_imageDecimalPoint.SelectedIndex < 0) comboBox_imageDecimalPoint.Text = "";
        }

        internal int comboBoxGetImageDecimalPoint()
        {
            int value = -1;
            Int32.TryParse(comboBox_imageDecimalPoint.Text, out value);
            return value;
        }

        internal void comboBoxSetAlignment(string alignment)
        {
            int result;
            switch (alignment)
            {
                case "Left":
                    result = 0;
                    break;
                case "Right":
                    result = 1;
                    break;
                case "Center":
                    result = 2;
                    break;

                default:
                    result = 0;
                    break;

            }
            comboBox_alignment.SelectedIndex = result;
        }

        internal string comboBoxGetAlignment()
        {
            string result;
            switch (comboBox_alignment.SelectedIndex)
            {
                case 0:
                    result = "Left";
                    break;
                case 1:
                    result = "Right";
                    break;
                case 2:
                    result = "Center";
                    break;

                default:
                    result = "Left";
                    break;

            }
            return result;
        }

        /// <summary>Отображение кнопки копирования значений для AOD</summary>
        public bool AOD
        {
            get
            {
                return button_Copy_text.Visible;
            }
            set
            {
                button_Copy_text.Visible = value;
            }
        }

        /// <summary>Отображение поля изображения при ошибке</summary>
        public bool ImageError
        {
            get
            {
                return comboBox_imageError.Visible;
            }
            set
            {
                comboBox_imageError.Visible = value;
                label06.Visible = value;
            }
        }

        /// <summary>Отображение поля изображения десятичного разделителя</summary>
        public bool ImageDecimalPoint
        {
            get
            {
                return comboBox_imageDecimalPoint.Visible;
            }
            set
            {
                comboBox_imageDecimalPoint.Visible = value;
                label07.Visible = value;
            }
        }

        /// <summary>Отображение чекбокса добавления нулей в начале</summary>
        public bool PaddingZero
        {
            get
            {
                return checkBox_addZero.Visible;
            }
            set
            {
                checkBox_addZero.Visible = value;
            }
        }

        [Browsable(true)]
        public event CollapseHandler Collapse;
        public delegate void CollapseHandler(object sender, EventArgs eventArgs);

        [Browsable(true)]
        protected internal event ValueChangedHandler ValueChanged;
        protected internal delegate void ValueChangedHandler(object sender, EventArgs eventArgs);

        [Browsable(true)]
        public event AOD_CopyHandler AOD_Copy_text;
        public delegate void AOD_CopyHandler(object sender, EventArgs eventArgs);

        /// <summary>Возвращает true если панель свернута</summary>
        public bool Collapsed
        {
            get
            {
                return !panel_text.Visible;
            }
            set
            {
                panel_text.Visible = !value;
            }
        }
       
        // кнопка копирования свойст для AOD
        private void button_Copy_text_Click(object sender, EventArgs e)
        {
            if (AOD_Copy_text != null)
            {
                EventArgs eventArgs = new EventArgs();
                AOD_Copy_text(this, eventArgs);
            }
        }

        // кнопка сворачивания
        private void button_Click(object sender, EventArgs e)
        {
            panel_text.Visible = !panel_text.Visible;
            if (Collapse != null)
            {
                EventArgs eventArgs = new EventArgs();
                Collapse(this, eventArgs);
            }
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (ValueChanged != null && !setValue)
            {
                EventArgs eventArgs = new EventArgs();
                ValueChanged(this, eventArgs);
            }
        }

        #region Standard events
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                ComboBox comboBox = sender as ComboBox;
                comboBox.Text = "";
                comboBox.SelectedIndex = -1;
                if (ValueChanged != null && !setValue)
                {
                    EventArgs eventArgs = new EventArgs();
                    ValueChanged(this, eventArgs);
                }
            }
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            //if (comboBox.Items.Count < 10) comboBox.DropDownHeight = comboBox.Items.Count * 35;
            //else comboBox.DropDownHeight = 106;
            float size = comboBox.Font.Size;
            Font myFont;
            FontFamily family = comboBox.Font.FontFamily;
            e.DrawBackground();
            int itemWidth = e.Bounds.Height;
            int itemHeight = e.Bounds.Height - 4;

            //SolidBrush solidBrush = new SolidBrush(Color.Black);
            //Rectangle rectangleFill = new Rectangle(2, e.Bounds.Top + 2,
            //        e.Bounds.Width, e.Bounds.Height - 4);
            //e.Graphics.FillRectangle(solidBrush, rectangleFill);
            //var src = new Bitmap(ListImagesFullName[image_index]);
            if (e.Index >= 0)
            {
                try
                {
                    using (FileStream stream = new FileStream(Form1.ListImagesFullName[e.Index], FileMode.Open, FileAccess.Read))
                    {
                        Image image = Image.FromStream(stream);
                        float scale = (float)itemWidth / image.Width;
                        if ((float)itemHeight / image.Height < scale) scale = (float)itemHeight / image.Height;
                        float itemWidthRec = image.Width * scale;
                        float itemHeightRec = image.Height * scale;
                        Rectangle rectangle = new Rectangle((int)(itemWidth - itemWidthRec) / 2 + 2,
                            e.Bounds.Top + (int)(itemHeight - itemHeightRec) / 2 + 2, (int)itemWidthRec, (int)itemHeightRec);
                        e.Graphics.DrawImage(image, rectangle);
                    }
                }
                catch { }
            }
            //e.Graphics.DrawImage(imageList1.Images[e.Index], rectangle);
            myFont = new Font(family, size);
            StringFormat lineAlignment = new StringFormat();
            //lineAlignment.Alignment = StringAlignment.Center;
            lineAlignment.LineAlignment = StringAlignment.Center;
            if (e.Index >= 0)
                e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), myFont, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + itemWidth, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), lineAlignment);
            e.DrawFocusRectangle();
        }

        private void comboBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null && !setValue)
            {
                EventArgs eventArgs = new EventArgs();
                ValueChanged(this, eventArgs);
            }
        }
        #endregion

        #region Settings Set/Clear
        /// <summary>Добавляет ссылки на картинки в выпадающие списки</summary>
        internal void ComboBoxAddItems(List<string> ListImages)
        {
            comboBox_image.Items.AddRange(ListImages.ToArray());
            comboBox_icon.Items.AddRange(ListImages.ToArray());
            comboBox_unit.Items.AddRange(ListImages.ToArray());

            comboBox_imageError.Items.AddRange(ListImages.ToArray());
            comboBox_imageDecimalPoint.Items.AddRange(ListImages.ToArray());
        }

        /// <summary>Очищает выпадающие списки с картинками, сбрасывает данные на значения по умолчанию</summary>
        internal void SettingsClear()
        {
            setValue = true;

            checkBox_Use.Checked = false;

            comboBox_image.Items.Clear();
            comboBox_image.Text = "";

            comboBox_icon.Items.Clear();
            comboBox_icon.Text = "";

            comboBox_unit.Items.Clear();
            comboBox_unit.Text = "";

            comboBox_imageError.Items.Clear();
            comboBox_imageError.Text = "";

            comboBox_imageDecimalPoint.Items.Clear();
            comboBox_imageDecimalPoint.Text = "";

            numericUpDown_imageX.Value = 0;
            numericUpDown_imageY.Value = 0;

            numericUpDown_iconX.Value = 0;
            numericUpDown_iconY.Value = 0;

            numericUpDown_spacing.Value = 0;

            comboBox_alignment.SelectedIndex = 0;
            checkBox_addZero.Checked = false;

            setValue = false;
        }
        #endregion

        #region contextMenu
        private void contextMenuStrip_X_Opening(object sender, CancelEventArgs e)
        {
            if ((MouseСoordinates.X < 0) || (MouseСoordinates.Y < 0))
            {
                contextMenuStrip_X.Items[0].Enabled = false;
            }
            else
            {
                contextMenuStrip_X.Items[0].Enabled = true;
            }
            decimal i = 0;
            if ((Clipboard.ContainsText() == true) && (decimal.TryParse(Clipboard.GetText(), out i)))
            {
                contextMenuStrip_X.Items[2].Enabled = true;
            }
            else
            {
                contextMenuStrip_X.Items[2].Enabled = false;
            }
        }

        private void contextMenuStrip_Y_Opening(object sender, CancelEventArgs e)
        {
            if ((MouseСoordinates.X < 0) || (MouseСoordinates.Y < 0))
            {
                contextMenuStrip_Y.Items[0].Enabled = false;
            }
            else
            {
                contextMenuStrip_Y.Items[0].Enabled = true;
            }
            decimal i = 0;
            if ((Clipboard.ContainsText() == true) && (decimal.TryParse(Clipboard.GetText(), out i)))
            {
                contextMenuStrip_Y.Items[2].Enabled = true;
            }
            else
            {
                contextMenuStrip_Y.Items[2].Enabled = false;
            }
        }

        private void вставитьКоординатуХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    NumericUpDown numericUpDown = sourceControl as NumericUpDown;
                    numericUpDown.Value = MouseСoordinates.X;
                }
            }
        }

        private void вставитьКоординатуYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    NumericUpDown numericUpDown = sourceControl as NumericUpDown;
                    numericUpDown.Value = MouseСoordinates.Y;
                }
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    NumericUpDown numericUpDown = sourceControl as NumericUpDown;
                    Clipboard.SetText(numericUpDown.Value.ToString());
                }
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    NumericUpDown numericUpDown = sourceControl as NumericUpDown;
                    //Если в буфере обмен содержится текст
                    if (Clipboard.ContainsText() == true)
                    {
                        //Извлекаем (точнее копируем) его и сохраняем в переменную
                        decimal i = 0;
                        if (decimal.TryParse(Clipboard.GetText(), out i))
                        {
                            if (i > numericUpDown.Maximum) i = numericUpDown.Maximum;
                            if (i < numericUpDown.Minimum) i = numericUpDown.Minimum;
                            numericUpDown.Value = i;
                        }
                    }

                }
            }
        }
        #endregion

        #region numericUpDown
        private void numericUpDown_picturesX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MouseСoordinates.X < 0) return;
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if (e.X <= numericUpDown.Controls[1].Width + 1)
            {
                // Click is in text area
                numericUpDown.Value = MouseСoordinates.X;
            }
        }

        private void numericUpDown_picturesY_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (MouseСoordinates.Y < 0) return;
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if (e.X <= numericUpDown.Controls[1].Width + 1)
            {
                // Click is in text area
                numericUpDown.Value = MouseСoordinates.Y;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null && !setValue)
            {
                EventArgs eventArgs = new EventArgs();
                ValueChanged(this, eventArgs);
            }
        }

        #endregion

        private void checkBox_Use_CheckedChanged(object sender, EventArgs e)
        {
            Control.ControlCollection controlCollection = panel_text.Controls;

            bool b = checkBox_Use.Checked;
            for (int i = 1; i < controlCollection.Count - 1; i++)
            {
                controlCollection[i].Enabled = b;
            }
        }

        
    }
}
