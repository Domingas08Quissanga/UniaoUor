using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace UniaoUor
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        private string GerarHashSHA256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach(byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));

                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmLogin Voltar = new frmLogin();
            this.Hide();
            Voltar.ShowDialog();
           
        }

        
           
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string Email = txtEmail.Text;
            string Senha = txtSenha.Text;
            DateTime dataNasc = dtpDataNasc.Value; 
            string Telefone = txtTelefone.Text; 
            string Tipo_usuario = "";
            
            
        }
        private void ArmazenarNoBancoDeDados(string nome, string email, string Tipo_usuario, DateTime dataNasc, string Telefone)
        {

            try
            {
                using (var conn = Conexao.Conectar())
                {

                    string query = "INSERT INTO usuario (Nome, Email, Tipo_usuario, dataNasc, Telefone,Senha) VALUES (@Nome, @Email, @Tipo_usuario, @dataNasc, @Telefone, @Senha)";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    string senhaHash = GerarHashSHA256 (senha);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Tipo_usuario", Tipo_usuario);
                    command.Parameters.AddWithValue("@dataNasc", dataNasc);
                    command.Parameters.AddWithValue("@Telefone", Telefone);
                    command.Parameters.AddWithValue("@Senha", Senha);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro MySql: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro geral: " + ex.Message);
            }
            

        }
        if (rBAdmin.Checked)
            {
                Tipo_usuario = "Admin";
            Dashboard mostrar = new Dashboard();
            mostrar.ShowDialog();
            this.Close();

    }
            else if (rBBene.Checked)
            {
                Tipo_usuario = "Beneficiario";
                frmSolici Solicitar = new frmSolici();
                Solicitar.ShowDialog();
                this.Close();

            }
            else if (rBDoador.Checked)
            {
                Tipo_usuario = "Doador";
                doacoes Doar = new doacoes();
                Doar.ShowDialog();
            this.Close();
            }
           
        private void btnCleanLogin_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtRepetirSenha.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";

            this.Close();
        }
    }
}
