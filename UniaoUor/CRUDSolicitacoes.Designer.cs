namespace UniaoUor
{
    partial class CRUDSolicitacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TelUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeUSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgSolic = new System.Windows.Forms.DataGridView();
            this.DataNascUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_impacto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_doacoes = new System.Windows.Forms.Button();
            this.btn_socilic = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TelUser
            // 
            this.TelUser.HeaderText = "Telefone";
            this.TelUser.Name = "TelUser";
            // 
            // TipoUSer
            // 
            this.TipoUSer.HeaderText = "Tipo";
            this.TipoUSer.Name = "TipoUSer";
            // 
            // EmailUser
            // 
            this.EmailUser.HeaderText = "Email";
            this.EmailUser.Name = "EmailUser";
            // 
            // NomeUSer
            // 
            this.NomeUSer.HeaderText = "Nome";
            this.NomeUSer.Name = "NomeUSer";
            // 
            // IDUser
            // 
            this.IDUser.HeaderText = "ID";
            this.IDUser.Name = "IDUser";
            // 
            // dtgSolic
            // 
            this.dtgSolic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUser,
            this.NomeUSer,
            this.EmailUser,
            this.TipoUSer,
            this.DataNascUser,
            this.TelUser});
            this.dtgSolic.Location = new System.Drawing.Point(244, 161);
            this.dtgSolic.Name = "dtgSolic";
            this.dtgSolic.Size = new System.Drawing.Size(641, 144);
            this.dtgSolic.TabIndex = 134;
            this.dtgSolic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataNascUser
            // 
            this.DataNascUser.HeaderText = "Data de Nascimento";
            this.DataNascUser.Name = "DataNascUser";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_impacto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_doacoes);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btn_socilic);
            this.panel1.Location = new System.Drawing.Point(-178, -200);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 737);
            this.panel1.TabIndex = 130;
            // 
            // btn_impacto
            // 
            this.btn_impacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_impacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_impacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_impacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_impacto.ForeColor = System.Drawing.Color.White;
            this.btn_impacto.Location = new System.Drawing.Point(155, 411);
            this.btn_impacto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_impacto.Name = "btn_impacto";
            this.btn_impacto.Size = new System.Drawing.Size(233, 38);
            this.btn_impacto.TabIndex = 59;
            this.btn_impacto.Text = "Impacto Social";
            this.btn_impacto.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(224, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 58;
            this.label3.Text = "Admin\r\n";
            // 
            // btn_doacoes
            // 
            this.btn_doacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_doacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doacoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doacoes.ForeColor = System.Drawing.Color.White;
            this.btn_doacoes.Location = new System.Drawing.Point(155, 375);
            this.btn_doacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_doacoes.Name = "btn_doacoes";
            this.btn_doacoes.Size = new System.Drawing.Size(233, 38);
            this.btn_doacoes.TabIndex = 41;
            this.btn_doacoes.Text = "Doações";
            this.btn_doacoes.UseVisualStyleBackColor = false;
            // 
            // btn_socilic
            // 
            this.btn_socilic.BackColor = System.Drawing.Color.Green;
            this.btn_socilic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_socilic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_socilic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_socilic.ForeColor = System.Drawing.Color.White;
            this.btn_socilic.Location = new System.Drawing.Point(155, 336);
            this.btn_socilic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_socilic.Name = "btn_socilic";
            this.btn_socilic.Size = new System.Drawing.Size(233, 38);
            this.btn_socilic.TabIndex = 40;
            this.btn_socilic.Text = "Solicitações";
            this.btn_socilic.UseVisualStyleBackColor = false;
            this.btn_socilic.Click += new System.EventHandler(this.btn_socilic_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(155, 300);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(233, 38);
            this.btnUsuario.TabIndex = 39;
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Chocolate;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(603, 414);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 54);
            this.btnVoltar.TabIndex = 133;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(250, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 22);
            this.label2.TabIndex = 132;
            this.label2.Text = "Nesta secção poderá ver todas as solicitações feitas\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(225, -40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 36);
            this.label4.TabIndex = 131;
            this.label4.Text = "Usuários\r\n";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(725, 414);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 54);
            this.btnSair.TabIndex = 129;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(238, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 139;
            this.label1.Text = "Solicitações";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UniaoUor.Properties.Resources.Untitled_design;
            this.pictureBox2.Location = new System.Drawing.Point(213, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniaoUor.Properties.Resources.Black_and_orange_Minimalist_Education_Logo__2_2;
            this.pictureBox1.Location = new System.Drawing.Point(744, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // CRUDSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 506);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgSolic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Name = "CRUDSolicitacoes";
            this.Load += new System.EventHandler(this.CRUDSolicitacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn TelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUSer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUser;
        private System.Windows.Forms.DataGridView dtgSolic;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_impacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_doacoes;
        private System.Windows.Forms.Button btn_socilic;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
    }
}