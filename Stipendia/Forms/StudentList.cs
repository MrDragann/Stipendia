using Stipendia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stipendia.Forms;

namespace Stipendia
{
    public partial class StudentList : Form
    {
        DataContext db;
        public StudentList()
        {
            InitializeComponent();
            db = new DataContext();

            var specialties = db.Specialties.ToList();
            comboBoxSpecialties.Items.Add(DefaultSort);
            foreach (var specialty in specialties)
            {
                comboBoxSpecialties.Items.Add(specialty.Abbreviature);
            }
            comboBoxSpecialties.SelectedIndex = 0;
            var ScholarshipCategories = db.ScholarshipCategories.ToList();
            comboBoxScholarshipCategory.Items.Add(DefaultSort);
            foreach (var ScholarshipCategory in ScholarshipCategories)
            {
                comboBoxScholarshipCategory.Items.Add(ScholarshipCategory.Name);
            }
            comboBoxScholarshipCategory.SelectedIndex = 0;

            comboBoxCourses.SelectedIndex = 0;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUStudent plForm = new CRUStudent();
            plForm.Show();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void начислитьСтипендиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargeScholarship plForm = new ChargeScholarship();
            plForm.Show();
        }

        private void просмотрНачисленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scholarships plForm = new Scholarships();
            plForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridSort();
        }
        const string DefaultSort = "*Все*";
        string GroupSort;
        string CourseSort;
        string ScholarshipCategorySort;
        string SpecialtySort;
        private void DataGridSort()
        {
            var students = StudentServices.Instance.StudentListSort(SpecialtySort, ScholarshipCategorySort, CourseSort, GroupSort);

            dataGridView1.Rows.Clear();
            var scholarshipCat = "";

            foreach (var student in students)
            {
                if (student.ScholarshipCategories.Count > 0)
                {
                    foreach (var scholCat in student.ScholarshipCategories)
                    {
                        scholarshipCat += (scholCat != student.ScholarshipCategories.Last()) ? scholCat.Name + ", " : scholCat.Name;
                    }
                }
                dataGridView1.Rows
                    .Add(student.Id,
                    student.Firstname,
                    student.Lastname,
                    student.Patronymic,
                    student.Group.CourseName,
                    student.Group.Name,
                    scholarshipCat,
                    student.Budget ? "Да" : "Нет");
                scholarshipCat = "";
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        
        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGroups.Items.Clear();
            var selectedCourse = comboBoxCourses.Text;
            var groups = db.Groups.Where(x => x.CourseName == selectedCourse);
            comboBoxGroups.Items.Add(DefaultSort);
            foreach (var group in groups)
            {
                comboBoxGroups.Items.Add(group.Name);
            }
            comboBoxGroups.SelectedIndex = 0;
            CourseSort = comboBoxCourses.Text;
            DataGridSort();
        }

        private void категорияСтипендииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditScholarshipCat plForm = new EditScholarshipCat();
            plForm.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                CRUStudent plForm = new CRUStudent(id);
                plForm.Show();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить студента?",
                "Удаление студента", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) //Если нажал нет
            {
            }

            if (result == DialogResult.Yes) //Если нажал Да
            {

                StudentServices.Instance.DeleteStudent(id);
            }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport plForm = new GenerateReport();
            plForm.Show();
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupSort = comboBoxGroups.Text;
            if (GroupSort != DefaultSort && GroupSort != null) 
            {
                dataGridView1.Columns["Group"].Visible = false;
            }
            else if(GroupSort == DefaultSort)
            {
                dataGridView1.Columns["Group"].Visible = true;
            }
            DataGridSort();
        }

        private void comboBoxScholarshipCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScholarshipCategorySort = comboBoxScholarshipCategory.Text;
            DataGridSort();
        }

        private void comboBoxSpecialties_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecialtySort = comboBoxSpecialties.Text;
            DataGridSort();
        }
    }
}
