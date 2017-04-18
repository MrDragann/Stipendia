using Stipendia.Models;
using Stipendia.MyExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stipendia
{
    public partial class ChargeScholarship : Form
    {
        DataContext db;
        public ChargeScholarship()
        {
            InitializeComponent();
            comboBoxCourses.SelectedIndex = 0;
        }

        private void ChargeScholarship_Load(object sender, EventArgs e)
        {
            foreach(var month in Extensions.Months)
            {
                comboBoxMonth.Items.Add(month);
            }
            comboBoxMonth.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SelectedMonth = comboBoxMonth.Text;
            var SelectedCourse = comboBoxCourses.Text;
            var SelectedGroup = comboBoxGroups.Text;
            var Responce = ScholarshipServices.Instance.PrepareChargeScholarship(SelectedMonth, SelectedCourse, SelectedGroup);
            
            if (Responce != "Ок")
            {
                DialogResult result = MessageBox.Show(Responce,
                "Ответ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                // Если нажато нет
                if (result == DialogResult.No)
                {
                }
                // Если нажато да
                if (result == DialogResult.Yes)
                {
                    ScholarshipServices.Instance.ChargeScholarship(SelectedMonth, SelectedCourse, SelectedGroup, true);
                    DialogResult LasResult = MessageBox.Show(SelectedMonth + SelectedCourse + SelectedGroup,
                    "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            else if (Responce == "Ок")
            {
                ScholarshipServices.Instance.ChargeScholarship(SelectedMonth, SelectedCourse, SelectedGroup);
            }
            
            Close();
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DataContext();
            comboBoxGroups.Items.Clear();
            var selectedCourse = comboBoxCourses.Text;
            var groups = db.Groups.Where(x => x.CourseName == selectedCourse);
            comboBoxGroups.Items.Add("*Все*");
            foreach (var group in groups)
            {
                comboBoxGroups.Items.Add(group.Name);
            }
            comboBoxGroups.SelectedIndex = 0;
        }
    }
}
