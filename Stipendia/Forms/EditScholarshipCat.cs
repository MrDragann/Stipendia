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
    public partial class EditScholarshipCat : Form
    {
        DataContext db;
        public EditScholarshipCat()
        {
            InitializeComponent();
        }

        private void EditScholarshipCat_Load(object sender, EventArgs e)
        {
            db = new DataContext();
            dataGridViewSCat.Rows.Clear();
            var ScholarshipCategories = db.ScholarshipCategories.ToList();
            foreach (var ScholarshipCategory in ScholarshipCategories)
            {
                dataGridViewSCat.Rows
                    .Add(ScholarshipCategory.Id,
                    ScholarshipCategory.Name,
                    ScholarshipCategory.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUScholCat plForm = new CRUScholCat();
            DialogResult result = plForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewSCat.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewSCat.CurrentRow.Cells[0].Value);
                CRUScholCat plForm = new CRUScholCat(id);
                plForm.Show();
            }
        }

        private void EditScholarshipCat_Activated(object sender, EventArgs e)
        {
            EditScholarshipCat_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewSCat.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить категорию?", 
                "Удаление категории", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) //Если нажал нет
            {
            }

            if (result == DialogResult.Yes) //Если нажал Да
            {
                
                using (var db = new DataContext())
                {
                    var SchCat = db.ScholarshipCategories.FirstOrDefault(x => x.Id == id);
                    db.ScholarshipCategories.Remove(SchCat);
                    db.SaveChanges();
                }
            }
        }
    }
}
