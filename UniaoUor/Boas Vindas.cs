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
    public partial class frm_BoasVindas : Form
    {
        public frm_BoasVindas()
        {
            InitializeComponent();
        }

        private void frm_BoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmLogin Entrar = new frmLogin();
            Entrar.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmLogin Entrar = new frmLogin();
            Entrar.ShowDialog();
            this.Close();
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSobre_Nos Sobre = new frmSobre_Nos();
            Sobre.ShowDialog();
            this.Close();
        }

        private void Contacto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contacto contacto= new Contacto();
            contacto.ShowDialog();
            this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin telalogin = new frmLogin();
            telalogin.Show ();
        }
    }
}
