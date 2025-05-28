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
    public partial class doacoes : Form
    {
        public doacoes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void doacoes_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_BoasVindas Boas = new frm_BoasVindas();
            Boas.ShowDialog();
            this.Close();



        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            material_Escolar Materiais = new material_Escolar();
            Materiais.ShowDialog();
            this.Close();
        }

        private void btn_propina_Click(object sender, EventArgs e)
        {
            propinas prop = new propinas();
            prop.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            propinas prop = new propinas();
            prop.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            material_Escolar Materiais = new material_Escolar();
            Materiais.ShowDialog();
            this.Close();
        }

        private void btnCleanLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
