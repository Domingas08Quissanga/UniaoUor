using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniaoUor
{
    public partial class propinas : Form
    {
        public propinas()
        {
            InitializeComponent();
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            this.Hide();
            material_Escolar telamaterial = new material_Escolar();
            telamaterial.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doação bem sucedida", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void btnCleanLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin telalogin = new frmLogin();
            telalogin.Show();

        }
    }
}
