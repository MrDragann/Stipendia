using Stipendia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stipendia
{
    public partial class CRUScholCat : Form
    {
        int CategoryId;
        bool isEdit = false;
        public CRUScholCat(int id)
        {
            InitializeComponent();
            isEdit = true;
            CategoryId = id;
            using (var db = new DataContext())
            {
                var SchCat = db.ScholarshipCategories.FirstOrDefault(x => x.Id == id);
                textBoxCategoryName.Text = SchCat.Name;
                textBoxCategoryValue.Text = SchCat.Value.ToString();
                if(SchCat.CategoryType == ScholarshipCategoryType.Privileges)
                {
                    radioButtonPrivileges.Checked = true;
                }
                else if (SchCat.CategoryType == ScholarshipCategoryType.Performance)
                {
                    radioButtonPerfomance.Checked = true;
                }
            }
            
        }
        public CRUScholCat()
        {
            InitializeComponent();
            isEdit = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CategoryName = textBoxCategoryName.Text;
            var CategoryValue = Convert.ToDouble(textBoxCategoryValue.Text);
            var CategoryType = radioButtonPerfomance.Checked ? ScholarshipCategoryType.Performance : ScholarshipCategoryType.Privileges;
            if (isEdit)
            {
                using (var db = new DataContext())
                {
                    var SchCat = db.ScholarshipCategories.FirstOrDefault(x => x.Id == CategoryId);
                    SchCat.Name = CategoryName;
                    SchCat.Value = CategoryValue;
                    SchCat.CategoryType = CategoryType;
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new DataContext())
                {
                    var SchCat = new ScholarshipCategory() { Name = CategoryName, Value = CategoryValue };
                    db.ScholarshipCategories.Add(SchCat);
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void CRUScholCat_Load(object sender, EventArgs e)
        {

        }
    }
}
