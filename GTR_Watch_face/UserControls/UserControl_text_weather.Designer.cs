
namespace AmazFit_Watchface_2
{
    partial class UserControl_text_weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_text_weather));
            this.panel_text.SuspendLayout();
            this.SuspendLayout();
            // 
            // label07
            // 
            resources.ApplyResources(this.label07, "label07");
            // 
            // checkBox_follow
            // 
            resources.ApplyResources(this.checkBox_follow, "checkBox_follow");
            // 
            // checkBox_addZero
            // 
            resources.ApplyResources(this.checkBox_addZero, "checkBox_addZero");
            // 
            // panel_text
            // 
            this.panel_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // label08
            // 
            resources.ApplyResources(this.label08, "label08");
            // 
            // UserControl_text_weather
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "UserControl_text_weather";
            this.panel_text.ResumeLayout(false);
            this.panel_text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
