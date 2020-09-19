namespace UIL_EAD_ProjetoDS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lklResetSenha = new System.Windows.Forms.LinkLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lklCadastrar = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(180, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Seja Bem Vindo!";
            this.lblTitulo.UseWaitCursor = true;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(125, 286);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(338, 33);
            this.txbUsuario.TabIndex = 1;
            this.txbUsuario.UseWaitCursor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(214, 420);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(139, 40);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.UseWaitCursor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lklResetSenha
            // 
            this.lklResetSenha.ActiveLinkColor = System.Drawing.Color.Snow;
            this.lklResetSenha.AutoSize = true;
            this.lklResetSenha.BackColor = System.Drawing.Color.AliceBlue;
            this.lklResetSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklResetSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lklResetSenha.Location = new System.Drawing.Point(387, 452);
            this.lklResetSenha.Name = "lklResetSenha";
            this.lklResetSenha.Size = new System.Drawing.Size(146, 16);
            this.lklResetSenha.TabIndex = 4;
            this.lklResetSenha.TabStop = true;
            this.lklResetSenha.Text = "Esqueci minha senha";
            this.lklResetSenha.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(120, 258);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(194, 25);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "E-mail ou Usuário";
            this.lblUsuario.UseWaitCursor = true;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(129, 333);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(78, 25);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            this.lblSenha.UseWaitCursor = true;
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(125, 361);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(338, 33);
            this.txbSenha.TabIndex = 7;
            this.txbSenha.UseWaitCursor = true;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // lklCadastrar
            // 
            this.lklCadastrar.ActiveLinkColor = System.Drawing.Color.Snow;
            this.lklCadastrar.AutoSize = true;
            this.lklCadastrar.BackColor = System.Drawing.Color.AliceBlue;
            this.lklCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCadastrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lklCadastrar.Location = new System.Drawing.Point(387, 420);
            this.lklCadastrar.Name = "lklCadastrar";
            this.lklCadastrar.Size = new System.Drawing.Size(140, 16);
            this.lklCadastrar.TabIndex = 8;
            this.lklCadastrar.TabStop = true;
            this.lklCadastrar.Text = "Quero me cadastrar";
            this.lklCadastrar.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(565, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lklCadastrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lklResetSenha);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.LinkLabel lklResetSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.LinkLabel lklCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}