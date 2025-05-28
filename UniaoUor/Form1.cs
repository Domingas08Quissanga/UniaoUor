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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string pass = txtPwd.Text;

            if (username == "admin" && pass =="1234")
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                propinas telapropina = new propinas();
                telapropina.Show();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou senha incorretos! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnCleanLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro CriarConta = new frmCadastro();
            this.Hide();
            CriarConta.ShowDialog();
        }
    }
}