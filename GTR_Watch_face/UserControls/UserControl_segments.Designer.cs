
namespace AmazFit_Watchface_2
{
    partial class UserControl_segments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_segments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_pictures = new System.Windows.Forms.Panel();
            this.checkBox_pictures_Use = new DarkControls.DarkCheckBox();
            this.comboBox_pictures_image = new DarkControls.DarkComboBox();
            this.dataGridView_coordinates_set = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_XY_InTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вставитьКоординатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_DisplayType = new DarkControls.DarkGroupBox();
            this.radioButton_Continuous = new DarkControls.DarkRadioButton();
            this.radioButton_Single = new DarkControls.DarkRadioButton();
            this.label01 = new DarkControls.DarkLabel();
            this.label02 = new DarkControls.DarkLabel();
            this.button_Copy_pictures = new DarkControls.DarkButton();
            this.button_pictures = new DarkControls.DarkButton();
            this.panel_pictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_coordinates_set)).BeginInit();
            this.contextMenuStrip_XY_InTable.SuspendLayout();
            this.groupBox_DisplayType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_pictures
            // 
            this.panel_pictures.Controls.Add(this.checkBox_pictures_Use);
            this.panel_pictures.Controls.Add(this.comboBox_pictures_image);
            this.panel_pictures.Controls.Add(this.dataGridView_coordinates_set);
            this.panel_pictures.Controls.Add(this.groupBox_DisplayType);
            this.panel_pictures.Controls.Add(this.label01);
            this.panel_pictures.Controls.Add(this.label02);
            this.panel_pictures.Controls.Add(this.button_Copy_pictures);
            resources.ApplyResources(this.panel_pictures, "panel_pictures");
            this.panel_pictures.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel_pictures.Name = "panel_pictures";
            // 
            // checkBox_pictures_Use
            // 
            resources.ApplyResources(this.checkBox_pictures_Use, "checkBox_pictures_Use");
            this.checkBox_pictures_Use.Name = "checkBox_pictures_Use";
            this.checkBox_pictures_Use.CheckedChanged += new System.EventHandler(this.checkBox_pictures_Use_CheckedChanged);
            this.checkBox_pictures_Use.Click += new System.EventHandler(this.checkBox_pictures_Use_Click);
            // 
            // comboBox_pictures_image
            // 
            this.comboBox_pictures_image.DropDownWidth = 75;
            resources.ApplyResources(this.comboBox_pictures_image, "comboBox_pictures_image");
            this.comboBox_pictures_image.FormattingEnabled = true;
            this.comboBox_pictures_image.Name = "comboBox_pictures_image";
            this.comboBox_pictures_image.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_DrawItem);
            this.comboBox_pictures_image.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox_MeasureItem);
            this.comboBox_pictures_image.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox_pictures_image.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            this.comboBox_pictures_image.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // dataGridView_coordinates_set
            // 
            this.dataGridView_coordinates_set.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_coordinates_set.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.dataGridView_coordinates_set.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_coordinates_set.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_coordinates_set.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridView_coordinates_set, "dataGridView_coordinates_set");
            this.dataGridView_coordinates_set.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_coordinates_set.ContextMenuStrip = this.contextMenuStrip_XY_InTable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_coordinates_set.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_coordinates_set.EnableHeadersVisualStyles = false;
            this.dataGridView_coordinates_set.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.dataGridView_coordinates_set.Name = "dataGridView_coordinates_set";
            this.dataGridView_coordinates_set.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_coordinates_set.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_coordinates_set.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.dataGridView_coordinates_set.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_coordinates_set.RowTemplate.Height = 18;
            this.dataGridView_coordinates_set.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_coordinates_set_CellClick);
            this.dataGridView_coordinates_set.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_coordinates_set_CellEndEdit);
            this.dataGridView_coordinates_set.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_coordinates_set_CellMouseDoubleClick);
            this.dataGridView_coordinates_set.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_coordinates_set_CellMouseDown);
            this.dataGridView_coordinates_set.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView_coordinates_set_RowPrePaint);
            this.dataGridView_coordinates_set.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_coordinates_set_RowsRemoved);
            this.dataGridView_coordinates_set.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_coordinates_set_UserAddedRow);
            this.dataGridView_coordinates_set.EnabledChanged += new System.EventHandler(this.dataGridView_coordinates_set_EnabledChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip_XY_InTable
            // 
            this.contextMenuStrip_XY_InTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_XY_InTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вставитьКоординатыToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьСтрокуToolStripMenuItem});
            this.contextMenuStrip_XY_InTable.Name = "contextMenuStrip_XY_InTable";
            resources.ApplyResources(this.contextMenuStrip_XY_InTable, "contextMenuStrip_XY_InTable");
            this.contextMenuStrip_XY_InTable.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_XY_InTable_Opening);
            // 
            // вставитьКоординатыToolStripMenuItem
            // 
            this.вставитьКоординатыToolStripMenuItem.Image = global::AmazFit_Watchface_2.Properties.Resources.Actions_insert_text_icon;
            this.вставитьКоординатыToolStripMenuItem.Name = "вставитьКоординатыToolStripMenuItem";
            resources.ApplyResources(this.вставитьКоординатыToolStripMenuItem, "вставитьКоординатыToolStripMenuItem");
            this.вставитьКоординатыToolStripMenuItem.Click += new System.EventHandler(this.вставитьКоординатыToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = global::AmazFit_Watchface_2.Properties.Resources.Files_Copy_File_icon;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            resources.ApplyResources(this.копироватьToolStripMenuItem, "копироватьToolStripMenuItem");
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Image = global::AmazFit_Watchface_2.Properties.Resources.Files_Clipboard_icon;
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            resources.ApplyResources(this.вставитьToolStripMenuItem, "вставитьToolStripMenuItem");
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // удалитьСтрокуToolStripMenuItem
            // 
            this.удалитьСтрокуToolStripMenuItem.Image = global::AmazFit_Watchface_2.Properties.Resources.table_row_delete_icon;
            this.удалитьСтрокуToolStripMenuItem.Name = "удалитьСтрокуToolStripMenuItem";
            resources.ApplyResources(this.удалитьСтрокуToolStripMenuItem, "удалитьСтрокуToolStripMenuItem");
            this.удалитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтрокуToolStripMenuItem_Click);
            // 
            // groupBox_DisplayType
            // 
            this.groupBox_DisplayType.Controls.Add(this.radioButton_Continuous);
            this.groupBox_DisplayType.Controls.Add(this.radioButton_Single);
            resources.ApplyResources(this.groupBox_DisplayType, "groupBox_DisplayType");
            this.groupBox_DisplayType.Name = "groupBox_DisplayType";
            this.groupBox_DisplayType.TabStop = false;
            this.groupBox_DisplayType.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
            // 
            // radioButton_Continuous
            // 
            resources.ApplyResources(this.radioButton_Continuous, "radioButton_Continuous");
            this.radioButton_Continuous.Name = "radioButton_Continuous";
            // 
            // radioButton_Single
            // 
            resources.ApplyResources(this.radioButton_Single, "radioButton_Single");
            this.radioButton_Single.Checked = true;
            this.radioButton_Single.Name = "radioButton_Single";
            this.radioButton_Single.TabStop = true;
            this.radioButton_Single.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label01
            // 
            resources.ApplyResources(this.label01, "label01");
            this.label01.Name = "label01";
            // 
            // label02
            // 
            resources.ApplyResources(this.label02, "label02");
            this.label02.Name = "label02";
            // 
            // button_Copy_pictures
            // 
            resources.ApplyResources(this.button_Copy_pictures, "button_Copy_pictures");
            this.button_Copy_pictures.Name = "button_Copy_pictures";
            this.button_Copy_pictures.UseVisualStyleBackColor = true;
            this.button_Copy_pictures.Click += new System.EventHandler(this.button_Copy_pictures_Click);
            // 
            // button_pictures
            // 
            resources.ApplyResources(this.button_pictures, "button_pictures");
            this.button_pictures.Name = "button_pictures";
            this.button_pictures.UseVisualStyleBackColor = true;
            this.button_pictures.Click += new System.EventHandler(this.button_pictures_Click);
            // 
            // UserControl_segments
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel_pictures);
            this.Controls.Add(this.button_pictures);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "UserControl_segments";
            this.Load += new System.EventHandler(this.UserControl_segments_Load);
            this.panel_pictures.ResumeLayout(false);
            this.panel_pictures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_coordinates_set)).EndInit();
            this.contextMenuStrip_XY_InTable.ResumeLayout(false);
            this.groupBox_DisplayType.ResumeLayout(false);
            this.groupBox_DisplayType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_pictures;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_XY_InTable;
        private System.Windows.Forms.ToolStripMenuItem вставитьКоординатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        internal DarkControls.DarkCheckBox checkBox_pictures_Use;
        public DarkControls.DarkComboBox comboBox_pictures_image;
        private DarkControls.DarkLabel label01;
        private DarkControls.DarkButton button_Copy_pictures;
        private DarkControls.DarkButton button_pictures;
        private DarkControls.DarkLabel label02;
        private System.Windows.Forms.DataGridView dataGridView_coordinates_set;
        private DarkControls.DarkGroupBox groupBox_DisplayType;
        private DarkControls.DarkRadioButton radioButton_Continuous;
        private DarkControls.DarkRadioButton radioButton_Single;
    }
}
