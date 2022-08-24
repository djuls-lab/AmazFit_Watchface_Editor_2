
namespace AmazFit_Watchface_2
{
    partial class UserControl_SystemFont_Group
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_SystemFont_Group));
            this.button_SystemFont = new DarkControls.DarkButton();
            this.panel_SystemFont = new System.Windows.Forms.Panel();
            this.userControl_FontRotate_goal = new AmazFit_Watchface_2.UserControl_FontRotate_weather();
            this.userControl_FontRotate = new AmazFit_Watchface_2.UserControl_FontRotate();
            this.userControl_SystemFont_goal = new AmazFit_Watchface_2.UserControl_SystemFont_weather();
            this.userControl_SystemFont = new AmazFit_Watchface_2.UserControl_SystemFont();
            this.panel_SystemFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SystemFont
            // 
            resources.ApplyResources(this.button_SystemFont, "button_SystemFont");
            this.button_SystemFont.Name = "button_SystemFont";
            this.button_SystemFont.UseVisualStyleBackColor = true;
            this.button_SystemFont.Click += new System.EventHandler(this.button_SystemFont_Click);
            // 
            // panel_SystemFont
            // 
            this.panel_SystemFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.panel_SystemFont.Controls.Add(this.userControl_FontRotate_goal);
            this.panel_SystemFont.Controls.Add(this.userControl_FontRotate);
            this.panel_SystemFont.Controls.Add(this.userControl_SystemFont_goal);
            this.panel_SystemFont.Controls.Add(this.userControl_SystemFont);
            resources.ApplyResources(this.panel_SystemFont, "panel_SystemFont");
            this.panel_SystemFont.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel_SystemFont.Name = "panel_SystemFont";
            // 
            // userControl_FontRotate_goal
            // 
            this.userControl_FontRotate_goal.AOD = true;
            resources.ApplyResources(this.userControl_FontRotate_goal, "userControl_FontRotate_goal");
            this.userControl_FontRotate_goal.Collapsed = true;
            this.userControl_FontRotate_goal.Follow = true;
            this.userControl_FontRotate_goal.Name = "userControl_FontRotate_goal";
            this.userControl_FontRotate_goal.Padding_zero = true;
            this.userControl_FontRotate_goal.Separator = true;
            this.userControl_FontRotate_goal.ShowUnit = true;
            this.userControl_FontRotate_goal.ValueChanged += new AmazFit_Watchface_2.UserControl_FontRotate.ValueChangedHandler(this.userControl_ValueChanged);
            this.userControl_FontRotate_goal.AOD_Copy_FontRotate += new AmazFit_Watchface_2.UserControl_FontRotate.AOD_CopyHandler(this.userControl_Copy_SystemFont);
            // 
            // userControl_FontRotate
            // 
            this.userControl_FontRotate.AOD = true;
            resources.ApplyResources(this.userControl_FontRotate, "userControl_FontRotate");
            this.userControl_FontRotate.Collapsed = true;
            this.userControl_FontRotate.Follow = true;
            this.userControl_FontRotate.Name = "userControl_FontRotate";
            this.userControl_FontRotate.Padding_zero = true;
            this.userControl_FontRotate.Separator = true;
            this.userControl_FontRotate.ShowUnit = true;
            this.userControl_FontRotate.ValueChanged += new AmazFit_Watchface_2.UserControl_FontRotate.ValueChangedHandler(this.userControl_ValueChanged);
            this.userControl_FontRotate.AOD_Copy_FontRotate += new AmazFit_Watchface_2.UserControl_FontRotate.AOD_CopyHandler(this.userControl_Copy_SystemFont);
            // 
            // userControl_SystemFont_goal
            // 
            this.userControl_SystemFont_goal.AOD = true;
            resources.ApplyResources(this.userControl_SystemFont_goal, "userControl_SystemFont_goal");
            this.userControl_SystemFont_goal.Collapsed = true;
            this.userControl_SystemFont_goal.Follow = true;
            this.userControl_SystemFont_goal.Name = "userControl_SystemFont_goal";
            this.userControl_SystemFont_goal.Padding_zero = true;
            this.userControl_SystemFont_goal.Separator = true;
            this.userControl_SystemFont_goal.ShowUnit = true;
            this.userControl_SystemFont_goal.ValueChanged += new AmazFit_Watchface_2.UserControl_SystemFont.ValueChangedHandler(this.userControl_ValueChanged);
            this.userControl_SystemFont_goal.AOD_Copy_SystemFont += new AmazFit_Watchface_2.UserControl_SystemFont.AOD_CopyHandler(this.userControl_Copy_SystemFont);
            // 
            // userControl_SystemFont
            // 
            this.userControl_SystemFont.AOD = true;
            resources.ApplyResources(this.userControl_SystemFont, "userControl_SystemFont");
            this.userControl_SystemFont.Collapsed = true;
            this.userControl_SystemFont.Follow = true;
            this.userControl_SystemFont.Name = "userControl_SystemFont";
            this.userControl_SystemFont.Padding_zero = true;
            this.userControl_SystemFont.Separator = true;
            this.userControl_SystemFont.ShowUnit = true;
            this.userControl_SystemFont.ValueChanged += new AmazFit_Watchface_2.UserControl_SystemFont.ValueChangedHandler(this.userControl_ValueChanged);
            this.userControl_SystemFont.AOD_Copy_SystemFont += new AmazFit_Watchface_2.UserControl_SystemFont.AOD_CopyHandler(this.userControl_Copy_SystemFont);
            // 
            // UserControl_SystemFont_Group
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel_SystemFont);
            this.Controls.Add(this.button_SystemFont);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "UserControl_SystemFont_Group";
            this.panel_SystemFont.ResumeLayout(false);
            this.panel_SystemFont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected DarkControls.DarkButton button_SystemFont;
        private System.Windows.Forms.Panel panel_SystemFont;
        public UserControl_SystemFont_weather userControl_SystemFont_goal;
        public UserControl_SystemFont userControl_SystemFont;
        public UserControl_FontRotate_weather userControl_FontRotate_goal;
        public UserControl_FontRotate userControl_FontRotate;
    }
}
