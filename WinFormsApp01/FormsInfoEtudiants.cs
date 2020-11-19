using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class FormsInfoEtudiants : Form
    {
        public FormsInfoEtudiants()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AlterForms formInfoEtudiants = new AlterForms();
            formInfoEtudiants.Show();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
