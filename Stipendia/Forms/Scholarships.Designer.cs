namespace Stipendia
{
    partial class Scholarships
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scholarships));
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxScholarshipCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стипендияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начислитьСтипендиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияСтипендииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(410, 68);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(135, 24);
            this.comboBoxGroups.TabIndex = 18;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Группа:";
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Items.AddRange(new object[] {
            "*Все*",
            "1 курс",
            "2 курс",
            "3 курс",
            "4 курс"});
            this.comboBoxCourses.Location = new System.Drawing.Point(410, 33);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(135, 24);
            this.comboBoxCourses.TabIndex = 16;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(362, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Курс:";
            // 
            // comboBoxScholarshipCategory
            // 
            this.comboBoxScholarshipCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxScholarshipCategory.FormattingEnabled = true;
            this.comboBoxScholarshipCategory.Location = new System.Drawing.Point(141, 68);
            this.comboBoxScholarshipCategory.Name = "comboBoxScholarshipCategory";
            this.comboBoxScholarshipCategory.Size = new System.Drawing.Size(153, 24);
            this.comboBoxScholarshipCategory.TabIndex = 14;
            this.comboBoxScholarshipCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxScholarshipCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тип стипендии:";
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Location = new System.Drawing.Point(141, 33);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(153, 24);
            this.comboBoxMonths.TabIndex = 12;
            this.comboBoxMonths.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonths_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Месяц:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Month,
            this.Course,
            this.Group,
            this.Category,
            this.Column7});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(913, 370);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.MinimumWidth = 125;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.MinimumWidth = 125;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.MinimumWidth = 130;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Month
            // 
            this.Month.HeaderText = "Месяц";
            this.Month.MinimumWidth = 70;
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 70;
            // 
            // Course
            // 
            this.Course.HeaderText = "Курс";
            this.Course.MinimumWidth = 60;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Width = 60;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 60;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 60;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория стипендии";
            this.Category.MinimumWidth = 200;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 215;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Стипендия (руб.)";
            this.Column7.MinimumWidth = 80;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стипендияToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 25);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // стипендияToolStripMenuItem
            // 
            this.стипендияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начислитьСтипендиюToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.стипендияToolStripMenuItem.Name = "стипендияToolStripMenuItem";
            this.стипендияToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.стипендияToolStripMenuItem.Text = "Стипендия";
            // 
            // начислитьСтипендиюToolStripMenuItem
            // 
            this.начислитьСтипендиюToolStripMenuItem.Name = "начислитьСтипендиюToolStripMenuItem";
            this.начислитьСтипендиюToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.начислитьСтипендиюToolStripMenuItem.Text = "Начислить стипендию";
            this.начислитьСтипендиюToolStripMenuItem.Click += new System.EventHandler(this.начислитьСтипендиюToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.отчетToolStripMenuItem.Text = "Сформировать отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.специальностьToolStripMenuItem,
            this.категорияСтипендииToolStripMenuItem,
            this.группаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // специальностьToolStripMenuItem
            // 
            this.специальностьToolStripMenuItem.Name = "специальностьToolStripMenuItem";
            this.специальностьToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.специальностьToolStripMenuItem.Text = "Специальности";
            // 
            // категорияСтипендииToolStripMenuItem
            // 
            this.категорияСтипендииToolStripMenuItem.Name = "категорияСтипендииToolStripMenuItem";
            this.категорияСтипендииToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.категорияСтипендииToolStripMenuItem.Text = "Категории стипендий";
            this.категорияСтипендииToolStripMenuItem.Click += new System.EventHandler(this.категорияСтипендииToolStripMenuItem_Click);
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.группаToolStripMenuItem.Text = "Группы";
            // 
            // Scholarships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(932, 482);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxScholarshipCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMonths);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scholarships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр начислений стипендий";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxScholarshipCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стипендияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начислитьСтипендиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорияСтипендииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
    }
}