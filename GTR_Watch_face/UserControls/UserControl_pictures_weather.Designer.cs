﻿
namespace AmazFit_Watchface_2
{
    partial class UserControl_pictures_weather
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_pictures_weather));
            this.toolTip_Weather = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pictures_count)).BeginInit();
            this.SuspendLayout();
            // 
            // label03
            // 
            resources.ApplyResources(this.label03, "label03");
            // 
            // comboBox_pictures_image
            // 
            this.toolTip_Weather.SetToolTip(this.comboBox_pictures_image, resources.GetString("comboBox_pictures_image.ToolTip"));
            // 
            // numericUpDown_pictures_count
            // 
            resources.ApplyResources(this.numericUpDown_pictures_count, "numericUpDown_pictures_count");
            // 
            // toolTip_Weather
            // 
            this.toolTip_Weather.ToolTipTitle = "Weather icons";
            // 
            // UserControl_pictures_weather
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "UserControl_pictures_weather";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pictures_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_Weather;
    }
}
