namespace Stipendia.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonScholarships = new System.Windows.Forms.Button();
            this.buttonChargeScholarship = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudents.Location = new System.Drawing.Point(92, 50);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(240, 40);
            this.buttonStudents.TabIndex = 0;
            this.buttonStudents.Text = "Просмотреть список студентов";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonScholarships
            // 
            this.buttonScholarships.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonScholarships.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScholarships.Location = new System.Drawing.Point(92, 112);
            this.buttonScholarships.Name = "buttonScholarships";
            this.buttonScholarships.Size = new System.Drawing.Size(240, 40);
            this.buttonScholarships.TabIndex = 1;
            this.buttonScholarships.Text = "Список начислений стипендий";
            this.buttonScholarships.UseVisualStyleBackColor = false;
            this.buttonScholarships.Click += new System.EventHandler(this.buttonScholarships_Click);
            // 
            // buttonChargeScholarship
            // 
            this.buttonChargeScholarship.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonChargeScholarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChargeScholarship.Location = new System.Drawing.Point(92, 172);
            this.buttonChargeScholarship.Name = "buttonChargeScholarship";
            this.buttonChargeScholarship.Size = new System.Drawing.Size(240, 40);
            this.buttonChargeScholarship.TabIndex = 2;
            this.buttonChargeScholarship.Text = "Начислить стипендию";
            this.buttonChargeScholarship.UseVisualStyleBackColor = false;
            this.buttonChargeScholarship.Click += new System.EventHandler(this.buttonChargeScholarship_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(92, 290);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(240, 40);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(92, 232);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(240, 40);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Сформировать отчет";
            this.buttonGenerateReport.UseVisualStyleBackColor = false;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 380);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonChargeScholarship);
            this.Controls.Add(this.buttonScholarships);
            this.Controls.Add(this.buttonStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начисление стипендий в учебном заведении";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonScholarships;
        private System.Windows.Forms.Button buttonChargeScholarship;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGenerateReport;
    }
}