namespace Stipendia
{
    partial class EditScholarshipCat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditScholarshipCat));
            this.dataGridViewSCat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewScCat = new System.Windows.Forms.Button();
            this.buttonEditScCat = new System.Windows.Forms.Button();
            this.buttonDelScCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSCat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSCat
            // 
            this.dataGridViewSCat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSCat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSCat.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSCat.MultiSelect = false;
            this.dataGridViewSCat.Name = "dataGridViewSCat";
            this.dataGridViewSCat.ReadOnly = true;
            this.dataGridViewSCat.RowHeadersWidth = 30;
            this.dataGridViewSCat.Size = new System.Drawing.Size(352, 283);
            this.dataGridViewSCat.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Категория";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во (руб.)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // buttonAddNewScCat
            // 
            this.buttonAddNewScCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewScCat.Location = new System.Drawing.Point(386, 55);
            this.buttonAddNewScCat.Name = "buttonAddNewScCat";
            this.buttonAddNewScCat.Size = new System.Drawing.Size(128, 41);
            this.buttonAddNewScCat.TabIndex = 3;
            this.buttonAddNewScCat.Text = "Добавить";
            this.buttonAddNewScCat.UseVisualStyleBackColor = true;
            this.buttonAddNewScCat.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditScCat
            // 
            this.buttonEditScCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditScCat.Location = new System.Drawing.Point(386, 114);
            this.buttonEditScCat.Name = "buttonEditScCat";
            this.buttonEditScCat.Size = new System.Drawing.Size(128, 41);
            this.buttonEditScCat.TabIndex = 4;
            this.buttonEditScCat.Text = "Изменить";
            this.buttonEditScCat.UseVisualStyleBackColor = true;
            this.buttonEditScCat.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelScCat
            // 
            this.buttonDelScCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelScCat.Location = new System.Drawing.Point(386, 172);
            this.buttonDelScCat.Name = "buttonDelScCat";
            this.buttonDelScCat.Size = new System.Drawing.Size(128, 41);
            this.buttonDelScCat.TabIndex = 5;
            this.buttonDelScCat.Text = "Удалить";
            this.buttonDelScCat.UseVisualStyleBackColor = true;
            this.buttonDelScCat.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditScholarshipCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.buttonDelScCat);
            this.Controls.Add(this.buttonEditScCat);
            this.Controls.Add(this.buttonAddNewScCat);
            this.Controls.Add(this.dataGridViewSCat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditScholarshipCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование категорий стипендий";
            this.Activated += new System.EventHandler(this.EditScholarshipCat_Activated);
            this.Load += new System.EventHandler(this.EditScholarshipCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSCat;
        private System.Windows.Forms.Button buttonAddNewScCat;
        private System.Windows.Forms.Button buttonEditScCat;
        private System.Windows.Forms.Button buttonDelScCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}