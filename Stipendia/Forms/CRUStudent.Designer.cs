namespace Stipendia
{
    partial class CRUStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUStudent));
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.radioButtonContract = new System.Windows.Forms.RadioButton();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBoxPerfomance = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxPrivileges = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstname.Location = new System.Drawing.Point(15, 46);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(184, 22);
            this.textBoxFirstname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите фамилию:";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastname.Location = new System.Drawing.Point(15, 101);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(184, 22);
            this.textBoxLastname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите имя:";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(15, 161);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(184, 22);
            this.textBoxPatronymic.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Введите отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(222, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Выберите курс:";
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Items.AddRange(new object[] {
            "1 курс",
            "2 курс",
            "3 курс",
            "4 курс"});
            this.comboBoxCourses.Location = new System.Drawing.Point(225, 44);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(153, 24);
            this.comboBoxCourses.TabIndex = 6;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(222, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Выберите группу:";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(225, 105);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(153, 24);
            this.comboBoxGroups.TabIndex = 7;
            // 
            // radioButtonContract
            // 
            this.radioButtonContract.AutoSize = true;
            this.radioButtonContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonContract.Location = new System.Drawing.Point(226, 161);
            this.radioButtonContract.Name = "radioButtonContract";
            this.radioButtonContract.Size = new System.Drawing.Size(87, 20);
            this.radioButtonContract.TabIndex = 8;
            this.radioButtonContract.Text = "Контракт";
            this.radioButtonContract.UseVisualStyleBackColor = true;
            this.radioButtonContract.CheckedChanged += new System.EventHandler(this.radioButtonContract_CheckedChanged);
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Checked = true;
            this.radioButtonBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBudget.Location = new System.Drawing.Point(321, 161);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(77, 20);
            this.radioButtonBudget.TabIndex = 9;
            this.radioButtonBudget.TabStop = true;
            this.radioButtonBudget.Text = "Бюджет";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.Location = new System.Drawing.Point(331, 260);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(104, 43);
            this.buttonAddStudent.TabIndex = 20;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Выберите тип стипендии:";
            // 
            // checkedListBoxPerfomance
            // 
            this.checkedListBoxPerfomance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxPerfomance.FormattingEnabled = true;
            this.checkedListBoxPerfomance.Location = new System.Drawing.Point(15, 231);
            this.checkedListBoxPerfomance.Name = "checkedListBoxPerfomance";
            this.checkedListBoxPerfomance.Size = new System.Drawing.Size(145, 72);
            this.checkedListBoxPerfomance.TabIndex = 10;
            this.checkedListBoxPerfomance.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPerfomance_ItemCheck);
            // 
            // checkedListBoxPrivileges
            // 
            this.checkedListBoxPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxPrivileges.FormattingEnabled = true;
            this.checkedListBoxPrivileges.Location = new System.Drawing.Point(159, 231);
            this.checkedListBoxPrivileges.Name = "checkedListBoxPrivileges";
            this.checkedListBoxPrivileges.Size = new System.Drawing.Size(155, 72);
            this.checkedListBoxPrivileges.TabIndex = 27;
            this.checkedListBoxPrivileges.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPrivileges_ItemCheck);
            // 
            // CRUStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 332);
            this.Controls.Add(this.checkedListBoxPrivileges);
            this.Controls.Add(this.checkedListBoxPerfomance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.radioButtonBudget);
            this.Controls.Add(this.radioButtonContract);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCourses);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.CRUStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.RadioButton radioButtonContract;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBoxPerfomance;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrivileges;
    }
}