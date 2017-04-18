using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stipendia.Models;

namespace Stipendia
{
    public partial class CRUStudent : Form
    {
        DataContext db = new DataContext();
        bool isEdit = false;
        int StudentId;
        public CRUStudent(int id)
        {
            InitializeComponent();
            Text = "Редактирование студента";
            isEdit = true;
            StudentId = id;
            using (var db = new DataContext())
            {
                var ScholarshipCategories = db.ScholarshipCategories.ToList();
                var Student = db.Students.Include(x=>x.ScholarshipCategories).Include(x=>x.Group).FirstOrDefault(x => x.Id == id);
                textBoxFirstname.Text = Student.Firstname;
                textBoxLastname.Text = Student.Lastname;
                textBoxPatronymic.Text = Student.Patronymic;
                if (Student.Budget) radioButtonBudget.Checked = true; else radioButtonContract.Checked = true;
                comboBoxCourses.Text = Student.Group.CourseName;
                comboBoxGroups.Text = Student.Group.Name;

                foreach (var ScholarshipCategory in ScholarshipCategories.Where(x => x.CategoryType == ScholarshipCategoryType.Performance))
                {
                    checkedListBoxPerfomance.Items.Add(ScholarshipCategory.Name);
                }
                foreach (var ScholarshipCategory in ScholarshipCategories.Where(x => x.CategoryType == ScholarshipCategoryType.Privileges))
                {
                    checkedListBoxPrivileges.Items.Add(ScholarshipCategory.Name);
                }
                if (Student.ScholarshipCategories.Count > 0)
                {
                    foreach (var category in Student.ScholarshipCategories.Where(x=>x.CategoryType== ScholarshipCategoryType.Performance))
                    {
                        for (var i = 0; i < checkedListBoxPerfomance.Items.Count; i++)
                        {
                            if (checkedListBoxPerfomance.Items[i].ToString() == category.Name)
                            {
                                checkedListBoxPerfomance.SetItemChecked(i, true);
                            }
                        }
                    }
                    foreach (var category in Student.ScholarshipCategories.Where(x => x.CategoryType == ScholarshipCategoryType.Privileges))
                    {
                        for (var i = 0; i < checkedListBoxPrivileges.Items.Count; i++)
                        {
                            if (checkedListBoxPrivileges.Items[i].ToString() == category.Name)
                            {
                                checkedListBoxPrivileges.SetItemChecked(i, true);
                            }
                        }
                    }
                }
            }
            buttonAddStudent.Text = "Сохранить";
        }
        public CRUStudent()
        {
            InitializeComponent();
           
            isEdit = false;
            var ScholarshipCategories = db.ScholarshipCategories.ToList();

            comboBoxCourses.SelectedIndex = 0;
            foreach (var ScholarshipCategory in ScholarshipCategories.Where(x => x.CategoryType == ScholarshipCategoryType.Performance))
            {
                checkedListBoxPerfomance.Items.Add(ScholarshipCategory.Name);
            }
            foreach (var ScholarshipCategory in ScholarshipCategories.Where(x => x.CategoryType == ScholarshipCategoryType.Privileges))
            {
                checkedListBoxPrivileges.Items.Add(ScholarshipCategory.Name);
            }
            radioButtonBudget.Checked = true;
            CheckNotReceiveCategory();
        }
        
        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGroups.Items.Clear();
            var selectedCourse = comboBoxCourses.Text;
            var groups = db.Groups.Where(x=>x.CourseName==selectedCourse);
            foreach(var group in groups)
            {
                comboBoxGroups.Items.Add(group.Name);
            }
            comboBoxGroups.SelectedIndex = 0;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var budget = radioButtonContract.Checked ? false : true;
            var SelectedPerfomanceCat = checkedListBoxPerfomance.CheckedItems.Cast<string>().ToList();
            var SelectedPrivilegesCat = checkedListBoxPrivileges.CheckedItems.Cast<string>().ToList();
            var SelectedCategories = new List<string>();
            if (SelectedPerfomanceCat.Count < 1)
            {
                SelectedCategories.Add("Не получает");
            }
            else
            {
                SelectedCategories.Add(SelectedPerfomanceCat[0]);
            }
            if (SelectedPrivilegesCat.Count > 0)
            {
                if (SelectedCategories.Contains("Не получает")) { SelectedCategories.Remove("Не получает"); }
                foreach(var privilege in SelectedPrivilegesCat)
                {
                    SelectedCategories.Add(privilege);
                }
            }
            var ScholarshipCategory = new List<ScholarshipCategory>();
            foreach (var category in SelectedCategories)
            {
                ScholarshipCategory.Add(db.ScholarshipCategories.FirstOrDefault(x => x.Name == category));
            }

            var NewStudent = new Student()
            {
                Firstname = textBoxFirstname.Text,
                Lastname = textBoxLastname.Text,
                Patronymic = textBoxPatronymic.Text,
                GroupId = db.Groups.Where(x => x.Name == comboBoxGroups.Text).FirstOrDefault().Id,
                Budget = budget
            };
            if (isEdit)
            {
                var EditStudent = db.Students.Include(x=>x.ScholarshipCategories).FirstOrDefault(x => x.Id == StudentId);
                EditStudent.Firstname = textBoxFirstname.Text;
                EditStudent.Lastname = textBoxLastname.Text;
                EditStudent.Patronymic = textBoxPatronymic.Text;
                EditStudent.GroupId = db.Groups.Where(x => x.Name == comboBoxGroups.Text).FirstOrDefault().Id;
                EditStudent.Budget = budget;
                EditStudent.ScholarshipCategories = ScholarshipCategory;
            }
            else
            {
                db.Students.Add(NewStudent);
                NewStudent.ScholarshipCategories = ScholarshipCategory;
            }
            db.SaveChanges();
            Close();
        }

        private void radioButtonContract_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonContract.Checked)
            {
                CheckNotReceiveCategory();
                checkedListBoxPerfomance.Enabled = false;
                UnCheckPrivileges();
                checkedListBoxPrivileges.Enabled = false;
            }
            else
            {
                checkedListBoxPerfomance.Enabled = true;
                checkedListBoxPrivileges.Enabled = true;
            }
        }
        private void UnCheckPrivileges()
        {
            for (var i = 0; i < checkedListBoxPrivileges.Items.Count; i++)
            {
                checkedListBoxPrivileges.SetItemChecked(i, false);
            }
        }
        private void CheckNotReceiveCategory()
        {
            for (var i = 0; i < checkedListBoxPerfomance.Items.Count; i++)
            {
                if (checkedListBoxPerfomance.Items[i].ToString() == "Не получает")
                {
                    checkedListBoxPerfomance.SetItemChecked(i, true);
                }
                else
                {
                    checkedListBoxPerfomance.SetItemChecked(i, false);
                }
            }
        }
        private void CRUStudent_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBoxPerfomance_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBoxPerfomance.Items.Count; ++ix)
            {
                if (ix != e.Index) checkedListBoxPerfomance.SetItemChecked(ix, false);
            }
        }

        private void checkedListBoxPrivileges_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}
