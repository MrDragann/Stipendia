namespace Stipendia
{
    partial class CRUScholCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUScholCat));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonPrivileges = new System.Windows.Forms.RadioButton();
            this.radioButtonPerfomance = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название категории стипендии:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategoryName.Location = new System.Drawing.Point(16, 61);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(319, 22);
            this.textBoxCategoryName.TabIndex = 1;
            // 
            // textBoxCategoryValue
            // 
            this.textBoxCategoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategoryValue.Location = new System.Drawing.Point(16, 135);
            this.textBoxCategoryValue.Name = "textBoxCategoryValue";
            this.textBoxCategoryValue.Size = new System.Drawing.Size(319, 22);
            this.textBoxCategoryValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите размер стипендии в руб.:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(173, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(289, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonPrivileges
            // 
            this.radioButtonPrivileges.AutoSize = true;
            this.radioButtonPrivileges.Checked = true;
            this.radioButtonPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPrivileges.Location = new System.Drawing.Point(276, 170);
            this.radioButtonPrivileges.Name = "radioButtonPrivileges";
            this.radioButtonPrivileges.Size = new System.Drawing.Size(72, 20);
            this.radioButtonPrivileges.TabIndex = 11;
            this.radioButtonPrivileges.TabStop = true;
            this.radioButtonPrivileges.Text = "Льготы";
            this.radioButtonPrivileges.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerfomance
            // 
            this.radioButtonPerfomance.AutoSize = true;
            this.radioButtonPerfomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPerfomance.Location = new System.Drawing.Point(143, 170);
            this.radioButtonPerfomance.Name = "radioButtonPerfomance";
            this.radioButtonPerfomance.Size = new System.Drawing.Size(120, 20);
            this.radioButtonPerfomance.TabIndex = 10;
            this.radioButtonPerfomance.Text = "Успеваемость";
            this.radioButtonPerfomance.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Укажите тип:";
            // 
            // CRUScholCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonPrivileges);
            this.Controls.Add(this.radioButtonPerfomance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCategoryValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUScholCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление категории стипендии";
            this.Load += new System.EventHandler(this.CRUScholCat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonPrivileges;
        private System.Windows.Forms.RadioButton radioButtonPerfomance;
        private System.Windows.Forms.Label label3;
    }
}