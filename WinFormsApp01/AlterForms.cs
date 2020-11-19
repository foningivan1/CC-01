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
    public partial class AlterForms : Form
    {
        public AlterForms()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormsInfoEtudiants formsInfoEtudiants = new FormsInfoEtudiants();
            formsInfoEtudiants.Show();
            FormEcole formEcole = new FormEcole();
            formEcole.Show();
        }
    }
}
