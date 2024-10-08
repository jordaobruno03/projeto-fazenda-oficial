namespace Sistema__Fazenda
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblSenhaTitulo = new System.Windows.Forms.Label();
            this.lblLoginTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCadastrese = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuarioTitulo
            // 
            this.lblUsuarioTitulo.AutoSize = true;
            this.lblUsuarioTitulo.Location = new System.Drawing.Point(87, 78);
            this.lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            this.lblUsuarioTitulo.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioTitulo.TabIndex = 0;
            this.lblUsuarioTitulo.Text = "Usuário:";
            // 
            // lblSenhaTitulo
            // 
            this.lblSenhaTitulo.AutoSize = true;
            this.lblSenhaTitulo.Location = new System.Drawing.Point(87, 139);
            this.lblSenhaTitulo.Name = "lblSenhaTitulo";
            this.lblSenhaTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaTitulo.TabIndex = 1;
            this.lblSenhaTitulo.Text = "Senha:";
            // 
            // lblLoginTitulo
            // 
            this.lblLoginTitulo.AutoSize = true;
            this.lblLoginTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitulo.Location = new System.Drawing.Point(84, 32);
            this.lblLoginTitulo.Name = "lblLoginTitulo";
            this.lblLoginTitulo.Size = new System.Drawing.Size(68, 34);
            this.lblLoginTitulo.TabIndex = 2;
            this.lblLoginTitulo.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnCadastrese
            // 
            this.btnCadastrese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrese.Location = new System.Drawing.Point(315, 242);
            this.btnCadastrese.Name = "btnCadastrese";
            this.btnCadastrese.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrese.TabIndex = 5;
            this.btnCadastrese.Text = "Cadastre-se";
            this.btnCadastrese.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(90, 242);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrarLogin.Location = new System.Drawing.Point(90, 204);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(299, 23);
            this.btnEntrarLogin.TabIndex = 7;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 315);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrese);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLoginTitulo);
            this.Controls.Add(this.lblSenhaTitulo);
            this.Controls.Add(this.lblUsuarioTitulo);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioTitulo;
        private System.Windows.Forms.Label lblSenhaTitulo;
        private System.Windows.Forms.Label lblLoginTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCadastrese;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrarLogin;
    }
}

