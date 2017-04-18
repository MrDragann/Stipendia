using Stipendia.Forms;
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
    public partial class Scholarships : Form
    {
        
        public Scholarships()
        {
            var db = new DataContext();
            InitializeComponent();
            
            var ScholarshipCategories = db.ScholarshipCategories.ToList();
            comboBoxScholarshipCategory.Items.Add(DefaultSort);
            foreach (var ScholarshipCategory in ScholarshipCategories)
            {
                comboBoxScholarshipCategory.Items.Add(ScholarshipCategory.Name);
            }
            comboBoxScholarshipCategory.SelectedIndex = 0;
            comboBoxMonths.Items.Add(DefaultSort);
            foreach (var moth in Extensions.Months)
            {
                comboBoxMonths.Items.Add(moth);
            }
            comboBoxMonths.SelectedIndex = 0;
            comboBoxCourses.SelectedIndex = 0;
        }

        private void Scholarships_Load(object sender, EventArgs e)
        {
            
        }
        
        const string DefaultSort = "*Все*";
        string MonthSort;
        string CourseSort;
        string GroupSort;
        string ScholarshipCategorySort;
        
        private void DataGridSort()
        {
            using (var db = new DataContext())
            {
                var Scholarships = db.Scholarships.Include(x => x.Students.Select(y=>y.ScholarshipCategories))
                    .ToList();

                if (MonthSort != DefaultSort && MonthSort != null)
                {
                    Scholarships = Scholarships
                    .Where(x => x.Month == MonthSort).ToList();
                }
                if (GroupSort != DefaultSort && GroupSort != null)
                {
                    var GroupId = db.Groups.Where(x => x.Name == GroupSort).FirstOrDefault().Id;
                    Scholarships = Scholarships
                    .Where(x => x.GroupId == GroupId).ToList();
                }
                if (CourseSort != DefaultSort && CourseSort != null)
                {
                    Scholarships = Scholarships
                    .Where(x => x.CourseName == CourseSort).ToList();
                }
                if (ScholarshipCategorySort != DefaultSort && ScholarshipCategorySort != null)
                {
                    Scholarships = Scholarships
                    .Where(x => x.Students.FirstOrDefault().ScholarshipCategories.FirstOrDefault().Name == ScholarshipCategorySort || x.Students.FirstOrDefault().ScholarshipCategories.LastOrDefault().Name == ScholarshipCategorySort).ToList();
                }

                dataGridView1.Rows.Clear();
                var scholarshipCat = "";
                var Groups = db.Groups.ToList();
                foreach (var scholarship in Scholarships)
                {
                    foreach(var student in scholarship.Students)
                    {
                        if (student.ScholarshipCategories.Count > 0)
                        {
                            foreach (var scholCat in student.ScholarshipCategories)
                            {
                                scholarshipCat += (scholCat != student.ScholarshipCategories.Last()) ? scholCat.Name + ", " : scholCat.Name;
                            }
                        }
                        var GroupName = Groups.Where(x => x.Id == student.GroupId).FirstOrDefault().Name;
                        dataGridView1.Rows
                        .Add(student.Id,
                        student.Firstname,
                        student.Lastname,
                        student.Patronymic,
                        scholarship.Month,
                        scholarship.CourseName,
                        GroupName,
                        scholarshipCat,
                        scholarship.Value);
                        scholarshipCat = "";
                    }
                    
                }
            }
        }

        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthSort = comboBoxMonths.Text;
            if (MonthSort != DefaultSort && GroupSort != null)
            {
                dataGridView1.Columns["Month"].Visible = false;
            }
            else if (MonthSort == DefaultSort)
            {
                dataGridView1.Columns["Month"].Visible = true;
            }
            DataGridSort();
        }

        private void comboBoxScholarshipCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScholarshipCategorySort = comboBoxScholarshipCategory.Text;
            DataGridSort();
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupSort = comboBoxGroups.Text;
            if (GroupSort != DefaultSort && GroupSort != null)
            {
                dataGridView1.Columns["Group"].Visible = false;
            }
            else if (GroupSort == DefaultSort)
            {
                dataGridView1.Columns["Group"].Visible = true;
            }
            DataGridSort();
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DataContext())
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
            }
            CourseSort = comboBoxCourses.Text;
            if (CourseSort != DefaultSort && GroupSort != null)
            {
                dataGridView1.Columns["Course"].Visible = false;
            }
            else if (CourseSort == DefaultSort)
            {
                dataGridView1.Columns["Course"].Visible = true;
            }
            DataGridSort();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport plForm = new GenerateReport();
            plForm.Show();
        }

        private void начислитьСтипендиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargeScholarship plForm = new ChargeScholarship();
            plForm.Show();
        }

        private void категорияСтипендииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditScholarshipCat plForm = new EditScholarshipCat();
            plForm.Show();
        }
    }
}
