using Stipendia.MyExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stipendia.Forms
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            string template = "C:/code/Stipendia/Stipendia/MyExtensions/Шаблон.docx";

            saveFileDialog1.Filter = "Word | *.docx";
            saveFileDialog1.DefaultExt = "docx";
            DialogResult Save = MessageBox.Show("Выберите путь для сохранения файла", "Сохранение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (Save == DialogResult.OK)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filenameSave = saveFileDialog1.FileName;
                string result = ScholarshipServices.Instance.CreateDocx(template, filenameSave, 
                    comboBoxMonth.Text, comboBoxCourses.Text, comboBoxGroups.Text);
                MessageBox.Show(result,"Ответ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void GenerateReport_Load(object sender, EventArgs e)
        {
            using(var db=new DataContext())
            {
                var Scholarships = db.Scholarships.ToList();
                
                var Months = Scholarships.Select(x => x.Month).Distinct().ToList();
                foreach (var month in Months)
                {
                    comboBoxMonth.Items.Add(month);
                }
                
                comboBoxMonth.SelectedIndex = 0;
                
            }
            
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new DataContext();
            var Groups = db.Scholarships.Where(x => x.Month == comboBoxMonth.Text)
                    .Select(x => x.GroupId).Distinct().ToList();
            comboBoxGroups.Items.Clear();
            var selectedCourse = comboBoxCourses.Text;
            var groups = db.Groups.Where(x => x.CourseName == selectedCourse);
            foreach (var group in groups)
            {
                if (Groups.Contains(group.Id))
                {
                    comboBoxGroups.Items.Add(group.Name);
                }
            }
            comboBoxGroups.SelectedIndex = 0;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db=new DataContext())
            {
                comboBoxCourses.Items.Clear();
                var Scholarships = db.Scholarships.ToList();
                var Courses = Scholarships.Where(x => x.Month == comboBoxMonth.Text)
                    .OrderBy(x => x.CourseName).Select(x => x.CourseName).Distinct().ToList();
                foreach (var course in Courses)
                {
                    comboBoxCourses.Items.Add(course);
                }
                comboBoxCourses.SelectedIndex = 0;
            }
        }
    }
}
