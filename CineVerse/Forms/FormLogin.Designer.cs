namespace CineVerse
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLoginEsquerda = new Panel();
            lblSloganLogin = new Label();
            lblLogoLogin = new Label();
            pnlLoginDireita = new Panel();
            lblIrParaRegisto = new Label();
            btnEntrar = new Button();
            lblErroLogin = new Label();
            chkMostrarPassword = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblSubtituloLogin = new Label();
            lblTituloLogin = new Label();
            pnlLoginEsquerda.SuspendLayout();
            pnlLoginDireita.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLoginEsquerda
            // 
            pnlLoginEsquerda.BackColor = Color.FromArgb(22, 26, 43);
            pnlLoginEsquerda.Controls.Add(lblSloganLogin);
            pnlLoginEsquerda.Controls.Add(lblLogoLogin);
            pnlLoginEsquerda.Dock = DockStyle.Left;
            pnlLoginEsquerda.Location = new Point(0, 0);
            pnlLoginEsquerda.Name = "pnlLoginEsquerda";
            pnlLoginEsquerda.Size = new Size(420, 560);
            pnlLoginEsquerda.TabIndex = 0;
            // 
            // lblSloganLogin
            // 
            lblSloganLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSloganLogin.ForeColor = Color.FromArgb(154, 160, 181);
            lblSloganLogin.Location = new Point(0, 275);
            lblSloganLogin.Name = "lblSloganLogin";
            lblSloganLogin.Size = new Size(420, 30);
            lblSloganLogin.TabIndex = 1;
            lblSloganLogin.Text = "O teu universo de anime";
            lblSloganLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogoLogin
            // 
            lblLogoLogin.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogoLogin.ForeColor = Color.FromArgb(244, 185, 66);
            lblLogoLogin.Location = new Point(0, 220);
            lblLogoLogin.Name = "lblLogoLogin";
            lblLogoLogin.Size = new Size(420, 50);
            lblLogoLogin.TabIndex = 0;
            lblLogoLogin.Text = "\tCINEVERSE";
            lblLogoLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginDireita
            // 
            pnlLoginDireita.Controls.Add(lblIrParaRegisto);
            pnlLoginDireita.Controls.Add(btnEntrar);
            pnlLoginDireita.Controls.Add(lblErroLogin);
            pnlLoginDireita.Controls.Add(chkMostrarPassword);
            pnlLoginDireita.Controls.Add(txtPassword);
            pnlLoginDireita.Controls.Add(lblPassword);
            pnlLoginDireita.Controls.Add(txtEmail);
            pnlLoginDireita.Controls.Add(lblEmail);
            pnlLoginDireita.Controls.Add(lblSubtituloLogin);
            pnlLoginDireita.Controls.Add(lblTituloLogin);
            pnlLoginDireita.Dock = DockStyle.Fill;
            pnlLoginDireita.Location = new Point(420, 0);
            pnlLoginDireita.Name = "pnlLoginDireita";
            pnlLoginDireita.Size = new Size(480, 560);
            pnlLoginDireita.TabIndex = 1;
            // 
            // lblIrParaRegisto
            // 
            lblIrParaRegisto.Cursor = Cursors.Hand;
            lblIrParaRegisto.ForeColor = Color.FromArgb(244, 185, 66);
            lblIrParaRegisto.Location = new Point(80, 460);
            lblIrParaRegisto.Name = "lblIrParaRegisto";
            lblIrParaRegisto.Size = new Size(320, 24);
            lblIrParaRegisto.TabIndex = 9;
            lblIrParaRegisto.Text = "Ainda não tens conta? Regista-te";
            lblIrParaRegisto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(244, 185, 66);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 160, 50);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 92);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(13, 15, 26);
            btnEntrar.Location = new Point(80, 392);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(320, 44);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblErroLogin
            // 
            lblErroLogin.ForeColor = Color.FromArgb(200, 52, 75);
            lblErroLogin.Location = new Point(80, 360);
            lblErroLogin.Name = "lblErroLogin";
            lblErroLogin.Size = new Size(320, 20);
            lblErroLogin.TabIndex = 7;
            // 
            // chkMostrarPassword
            // 
            chkMostrarPassword.AutoSize = true;
            chkMostrarPassword.ForeColor = Color.FromArgb(154, 160, 181);
            chkMostrarPassword.Location = new Point(80, 328);
            chkMostrarPassword.Name = "chkMostrarPassword";
            chkMostrarPassword.Size = new Size(160, 21);
            chkMostrarPassword.TabIndex = 6;
            chkMostrarPassword.Text = "\tMostrar palavra-passe";
            chkMostrarPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(31, 36, 56);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(242, 242, 245);
            txtPassword.Location = new Point(80, 286);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 29);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(154, 160, 181);
            lblPassword.Location = new Point(80, 262);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 17);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "\tPalavra-passe";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(31, 36, 56);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(242, 242, 245);
            txtEmail.Location = new Point(80, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "\texemplo@email.com";
            txtEmail.Size = new Size(320, 29);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(154, 160, 181);
            lblEmail.Location = new Point(80, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 17);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "\tEmail";
            // 
            // lblSubtituloLogin
            // 
            lblSubtituloLogin.AutoSize = true;
            lblSubtituloLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituloLogin.ForeColor = Color.FromArgb(154, 160, 181);
            lblSubtituloLogin.Location = new Point(80, 128);
            lblSubtituloLogin.Name = "lblSubtituloLogin";
            lblSubtituloLogin.Size = new Size(170, 17);
            lblSubtituloLogin.TabIndex = 1;
            lblSubtituloLogin.Text = "Inicia sessão para continuar";
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLogin.Location = new Point(76, 80);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(288, 40);
            lblTituloLogin.TabIndex = 0;
            lblTituloLogin.Text = "Bem-vindo de volta";
            // 
            // FormLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 15, 26);
            ClientSize = new Size(900, 560);
            Controls.Add(pnlLoginDireita);
            Controls.Add(pnlLoginEsquerda);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(242, 242, 245);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineVerse - Iniciar sessão";
            pnlLoginEsquerda.ResumeLayout(false);
            pnlLoginDireita.ResumeLayout(false);
            pnlLoginDireita.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLoginEsquerda;
        private Label lblSloganLogin;
        private Label lblLogoLogin;
        private Panel pnlLoginDireita;
        private Label lblEmail;
        private Label lblSubtituloLogin;
        private Label lblTituloLogin;
        private CheckBox chkMostrarPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblIrParaRegisto;
        private Button btnEntrar;
        private Label lblErroLogin;
    }
}
