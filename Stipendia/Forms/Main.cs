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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            StudentList plForm = new StudentList();
            plForm.Show();
        }

        private void buttonChargeScholarship_Click(object sender, EventArgs e)
        {
            ChargeScholarship plForm = new ChargeScholarship();
            plForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonScholarships_Click(object sender, EventArgs e)
        {
            Scholarships plForm = new Scholarships();
            plForm.Show();
        }

        public void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport plForm = new GenerateReport();
            plForm.Show();
        }
    }
}
