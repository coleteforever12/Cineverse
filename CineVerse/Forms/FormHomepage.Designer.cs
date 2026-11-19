namespace CineVerse.Forms
{
    partial class FormHomepage
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
            pnlTopBar = new Panel();
            picAvatar = new PictureBox();
            lblNomeUtilizador = new Label();
            txtPesquisa = new TextBox();
            lblLogoTopo = new Label();
            pnlSidebar = new Panel();
            btnNavProfile = new Button();
            btnNavMyList = new Button();
            btnNavExplore = new Button();
            btnNavHome = new Button();
            pnlConteudo = new Panel();
            pnlBanner = new Panel();
            pnlBannerImagem = new Panel();
            pnlIndicador2 = new Panel();
            pnlIndicador3 = new Panel();
            pnlIndicador4 = new Panel();
            pnlIndicador1 = new Panel();
            btnBannerSeguinte = new Button();
            btnBannerAnterior = new Button();
            pnlBannerTexto = new Panel();
            btnVerDetalhes = new Button();
            lblBannerSinopse = new Label();
            lblBannerGeneros = new Label();
            lblBannerTitulo = new Label();
            lblBannerDestaque = new Label();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlConteudo.SuspendLayout();
            pnlBanner.SuspendLayout();
            pnlBannerImagem.SuspendLayout();
            pnlBannerTexto.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(22, 26, 43);
            pnlTopBar.Controls.Add(picAvatar);
            pnlTopBar.Controls.Add(lblNomeUtilizador);
            pnlTopBar.Controls.Add(txtPesquisa);
            pnlTopBar.Controls.Add(lblLogoTopo);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1200, 64);
            pnlTopBar.TabIndex = 0;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.FromArgb(244, 185, 66);
            picAvatar.Cursor = Cursors.Hand;
            picAvatar.Location = new Point(1136, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(40, 40);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 3;
            picAvatar.TabStop = false;
            // 
            // lblNomeUtilizador
            // 
            lblNomeUtilizador.Location = new Point(964, 20);
            lblNomeUtilizador.Name = "lblNomeUtilizador";
            lblNomeUtilizador.Size = new Size(160, 24);
            lblNomeUtilizador.TabIndex = 2;
            lblNomeUtilizador.Text = "Utilizador";
            lblNomeUtilizador.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BackColor = Color.FromArgb(31, 36, 56);
            txtPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisa.Font = new Font("Segoe UI", 11.25F);
            txtPesquisa.ForeColor = Color.FromArgb(242, 242, 245);
            txtPesquisa.Location = new Point(244, 18);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar animes...";
            txtPesquisa.Size = new Size(360, 27);
            txtPesquisa.TabIndex = 1;
            // 
            // lblLogoTopo
            // 
            lblLogoTopo.AutoSize = true;
            lblLogoTopo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblLogoTopo.ForeColor = Color.FromArgb(244, 185, 66);
            lblLogoTopo.Location = new Point(20, 17);
            lblLogoTopo.Name = "lblLogoTopo";
            lblLogoTopo.Size = new Size(123, 30);
            lblLogoTopo.TabIndex = 0;
            lblLogoTopo.Text = "CINEVERSE";
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnNavProfile);
            pnlSidebar.Controls.Add(btnNavMyList);
            pnlSidebar.Controls.Add(btnNavExplore);
            pnlSidebar.Controls.Add(btnNavHome);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 64);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 636);
            pnlSidebar.TabIndex = 1;
            // 
            // btnNavProfile
            // 
            btnNavProfile.BackColor = Color.FromArgb(22, 26, 43);
            btnNavProfile.Cursor = Cursors.Hand;
            btnNavProfile.FlatAppearance.BorderSize = 0;
            btnNavProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 36, 56);
            btnNavProfile.FlatStyle = FlatStyle.Flat;
            btnNavProfile.Font = new Font("Segoe UI", 11.25F);
            btnNavProfile.ForeColor = Color.FromArgb(154, 160, 181);
            btnNavProfile.ImeMode = ImeMode.NoControl;
            btnNavProfile.Location = new Point(0, 168);
            btnNavProfile.Name = "btnNavProfile";
            btnNavProfile.Padding = new Padding(20, 0, 0, 0);
            btnNavProfile.Size = new Size(220, 48);
            btnNavProfile.TabIndex = 3;
            btnNavProfile.Text = "Profile";
            btnNavProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnNavProfile.UseVisualStyleBackColor = false;
            // 
            // btnNavMyList
            // 
            btnNavMyList.BackColor = Color.FromArgb(22, 26, 43);
            btnNavMyList.Cursor = Cursors.Hand;
            btnNavMyList.FlatAppearance.BorderSize = 0;
            btnNavMyList.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 36, 56);
            btnNavMyList.FlatStyle = FlatStyle.Flat;
            btnNavMyList.Font = new Font("Segoe UI", 11.25F);
            btnNavMyList.ForeColor = Color.FromArgb(154, 160, 181);
            btnNavMyList.ImeMode = ImeMode.NoControl;
            btnNavMyList.Location = new Point(0, 120);
            btnNavMyList.Name = "btnNavMyList";
            btnNavMyList.Padding = new Padding(20, 0, 0, 0);
            btnNavMyList.Size = new Size(220, 48);
            btnNavMyList.TabIndex = 2;
            btnNavMyList.Text = "My List";
            btnNavMyList.TextAlign = ContentAlignment.MiddleLeft;
            btnNavMyList.UseVisualStyleBackColor = false;
            // 
            // btnNavExplore
            // 
            btnNavExplore.BackColor = Color.FromArgb(22, 26, 43);
            btnNavExplore.Cursor = Cursors.Hand;
            btnNavExplore.FlatAppearance.BorderSize = 0;
            btnNavExplore.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 36, 56);
            btnNavExplore.FlatStyle = FlatStyle.Flat;
            btnNavExplore.Font = new Font("Segoe UI", 11.25F);
            btnNavExplore.ForeColor = Color.FromArgb(154, 160, 181);
            btnNavExplore.Location = new Point(0, 72);
            btnNavExplore.Name = "btnNavExplore";
            btnNavExplore.Padding = new Padding(20, 0, 0, 0);
            btnNavExplore.Size = new Size(220, 48);
            btnNavExplore.TabIndex = 1;
            btnNavExplore.Text = "Explore";
            btnNavExplore.TextAlign = ContentAlignment.MiddleLeft;
            btnNavExplore.UseVisualStyleBackColor = false;
            // 
            // btnNavHome
            // 
            btnNavHome.BackColor = Color.FromArgb(31, 36, 56);
            btnNavHome.Cursor = Cursors.Hand;
            btnNavHome.FlatAppearance.BorderSize = 0;
            btnNavHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 36, 56);
            btnNavHome.FlatStyle = FlatStyle.Flat;
            btnNavHome.Font = new Font("Segoe UI", 11.25F);
            btnNavHome.ForeColor = Color.FromArgb(244, 185, 66);
            btnNavHome.Location = new Point(0, 24);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.Padding = new Padding(20, 0, 0, 0);
            btnNavHome.Size = new Size(220, 48);
            btnNavHome.TabIndex = 0;
            btnNavHome.Text = "\tHome";
            btnNavHome.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHome.UseVisualStyleBackColor = false;
            // 
            // pnlConteudo
            // 
            pnlConteudo.AutoScroll = true;
            pnlConteudo.Controls.Add(pnlBanner);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(220, 64);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(980, 636);
            pnlConteudo.TabIndex = 2;
            // 
            // pnlBanner
            // 
            pnlBanner.BackColor = Color.FromArgb(22, 26, 43);
            pnlBanner.Controls.Add(pnlBannerImagem);
            pnlBanner.Controls.Add(pnlBannerTexto);
            pnlBanner.Location = new Point(24, 24);
            pnlBanner.Name = "pnlBanner";
            pnlBanner.Size = new Size(932, 300);
            pnlBanner.TabIndex = 0;
            // 
            // pnlBannerImagem
            // 
            pnlBannerImagem.BackColor = Color.FromArgb(31, 36, 56);
            pnlBannerImagem.BackgroundImageLayout = ImageLayout.Zoom;
            pnlBannerImagem.Controls.Add(pnlIndicador2);
            pnlBannerImagem.Controls.Add(pnlIndicador3);
            pnlBannerImagem.Controls.Add(pnlIndicador4);
            pnlBannerImagem.Controls.Add(pnlIndicador1);
            pnlBannerImagem.Controls.Add(btnBannerSeguinte);
            pnlBannerImagem.Controls.Add(btnBannerAnterior);
            pnlBannerImagem.Dock = DockStyle.Fill;
            pnlBannerImagem.Location = new Point(380, 0);
            pnlBannerImagem.Name = "pnlBannerImagem";
            pnlBannerImagem.Size = new Size(552, 300);
            pnlBannerImagem.TabIndex = 1;
            // 
            // pnlIndicador2
            // 
            pnlIndicador2.BackColor = Color.FromArgb(154, 160, 181);
            pnlIndicador2.Cursor = Cursors.Hand;
            pnlIndicador2.Location = new Point(244, 276);
            pnlIndicador2.Name = "pnlIndicador2";
            pnlIndicador2.Size = new Size(28, 6);
            pnlIndicador2.TabIndex = 12;
            // 
            // pnlIndicador3
            // 
            pnlIndicador3.BackColor = Color.FromArgb(154, 160, 181);
            pnlIndicador3.Cursor = Cursors.Hand;
            pnlIndicador3.Location = new Point(280, 276);
            pnlIndicador3.Name = "pnlIndicador3";
            pnlIndicador3.Size = new Size(28, 6);
            pnlIndicador3.TabIndex = 12;
            // 
            // pnlIndicador4
            // 
            pnlIndicador4.BackColor = Color.FromArgb(154, 160, 181);
            pnlIndicador4.Cursor = Cursors.Hand;
            pnlIndicador4.Location = new Point(316, 276);
            pnlIndicador4.Name = "pnlIndicador4";
            pnlIndicador4.Size = new Size(28, 6);
            pnlIndicador4.TabIndex = 12;
            // 
            // pnlIndicador1
            // 
            pnlIndicador1.BackColor = Color.FromArgb(244, 185, 66);
            pnlIndicador1.Cursor = Cursors.Hand;
            pnlIndicador1.Location = new Point(208, 276);
            pnlIndicador1.Name = "pnlIndicador1";
            pnlIndicador1.Size = new Size(28, 6);
            pnlIndicador1.TabIndex = 11;
            // 
            // btnBannerSeguinte
            // 
            btnBannerSeguinte.BackColor = Color.FromArgb(13, 15, 26);
            btnBannerSeguinte.Cursor = Cursors.Hand;
            btnBannerSeguinte.FlatAppearance.BorderSize = 0;
            btnBannerSeguinte.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 36, 56);
            btnBannerSeguinte.FlatStyle = FlatStyle.Flat;
            btnBannerSeguinte.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBannerSeguinte.ForeColor = Color.FromArgb(242, 242, 245);
            btnBannerSeguinte.ImeMode = ImeMode.NoControl;
            btnBannerSeguinte.Location = new Point(496, 130);
            btnBannerSeguinte.Name = "btnBannerSeguinte";
            btnBannerSeguinte.Size = new Size(40, 40);
            btnBannerSeguinte.TabIndex = 10;
            btnBannerSeguinte.Text = "›";
            btnBannerSeguinte.UseVisualStyleBackColor = false;
            // 
            // btnBannerAnterior
            // 
            btnBannerAnterior.BackColor = Color.FromArgb(13, 15, 26);
            btnBannerAnterior.Cursor = Cursors.Hand;
            btnBannerAnterior.FlatAppearance.BorderSize = 0;
            btnBannerAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 36, 56);
            btnBannerAnterior.FlatStyle = FlatStyle.Flat;
            btnBannerAnterior.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBannerAnterior.ForeColor = Color.FromArgb(242, 242, 245);
            btnBannerAnterior.Location = new Point(16, 130);
            btnBannerAnterior.Name = "btnBannerAnterior";
            btnBannerAnterior.Size = new Size(40, 40);
            btnBannerAnterior.TabIndex = 9;
            btnBannerAnterior.Text = "‹";
            btnBannerAnterior.UseVisualStyleBackColor = false;
            // 
            // pnlBannerTexto
            // 
            pnlBannerTexto.Controls.Add(btnVerDetalhes);
            pnlBannerTexto.Controls.Add(lblBannerSinopse);
            pnlBannerTexto.Controls.Add(lblBannerGeneros);
            pnlBannerTexto.Controls.Add(lblBannerTitulo);
            pnlBannerTexto.Controls.Add(lblBannerDestaque);
            pnlBannerTexto.Dock = DockStyle.Left;
            pnlBannerTexto.Location = new Point(0, 0);
            pnlBannerTexto.Name = "pnlBannerTexto";
            pnlBannerTexto.Size = new Size(380, 300);
            pnlBannerTexto.TabIndex = 0;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.BackColor = Color.FromArgb(244, 185, 66);
            btnVerDetalhes.Cursor = Cursors.Hand;
            btnVerDetalhes.FlatAppearance.BorderSize = 0;
            btnVerDetalhes.FlatAppearance.MouseDownBackColor = Color.FromArgb(214, 160, 50);
            btnVerDetalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 203, 92);
            btnVerDetalhes.FlatStyle = FlatStyle.Flat;
            btnVerDetalhes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnVerDetalhes.ForeColor = Color.FromArgb(13, 15, 26);
            btnVerDetalhes.Location = new Point(72, 202);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(160, 44);
            btnVerDetalhes.TabIndex = 4;
            btnVerDetalhes.Text = "VER DETALHES";
            btnVerDetalhes.UseVisualStyleBackColor = false;
            // 
            // lblBannerSinopse
            // 
            lblBannerSinopse.Location = new Point(24, 112);
            lblBannerSinopse.Name = "lblBannerSinopse";
            lblBannerSinopse.Size = new Size(332, 80);
            lblBannerSinopse.TabIndex = 3;
            lblBannerSinopse.Text = "Sinopse curta do anime em destaque. Este texto é provisório.";
            // 
            // lblBannerGeneros
            // 
            lblBannerGeneros.ForeColor = Color.FromArgb(154, 160, 181);
            lblBannerGeneros.Location = new Point(24, 112);
            lblBannerGeneros.Name = "lblBannerGeneros";
            lblBannerGeneros.Size = new Size(332, 24);
            lblBannerGeneros.TabIndex = 2;
            lblBannerGeneros.Text = "Ação · Fantasia · Aventura";
            // 
            // lblBannerTitulo
            // 
            lblBannerTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBannerTitulo.Location = new Point(24, 56);
            lblBannerTitulo.Name = "lblBannerTitulo";
            lblBannerTitulo.Size = new Size(332, 48);
            lblBannerTitulo.TabIndex = 1;
            lblBannerTitulo.Text = "Solo Leveling";
            // 
            // lblBannerDestaque
            // 
            lblBannerDestaque.AutoSize = true;
            lblBannerDestaque.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBannerDestaque.ForeColor = Color.FromArgb(244, 185, 66);
            lblBannerDestaque.Location = new Point(24, 28);
            lblBannerDestaque.Name = "lblBannerDestaque";
            lblBannerDestaque.Size = new Size(87, 15);
            lblBannerDestaque.TabIndex = 0;
            lblBannerDestaque.Text = "EM DESTAQUE";
            // 
            // FormHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 15, 26);
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlTopBar);
            Font = new Font("Segoe UI", 9.75F);
            ForeColor = Color.FromArgb(242, 242, 245);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormHomepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CineVerse";
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlConteudo.ResumeLayout(false);
            pnlBanner.ResumeLayout(false);
            pnlBannerImagem.ResumeLayout(false);
            pnlBannerTexto.ResumeLayout(false);
            pnlBannerTexto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopBar;
        private Label lblLogoTopo;
        private PictureBox picAvatar;
        private Label lblNomeUtilizador;
        private TextBox txtPesquisa;
        private Panel pnlSidebar;
        private Button btnNavExplore;
        private Button btnNavHome;
        private Button btnNavMyList;
        private Panel pnlConteudo;
        private Button btnNavProfile;
        private Panel pnlBanner;
        private Panel pnlBannerImagem;
        private Panel pnlBannerTexto;
        private Label lblBannerTitulo;
        private Label lblBannerDestaque;
        private Button btnVerDetalhes;
        private Label lblBannerSinopse;
        private Label lblBannerGeneros;
        private Panel pnlIndicador3;
        private Panel pnlIndicador2;
        private Panel pnlIndicador4;
        private Panel pnlIndicador1;
        private Button btnBannerSeguinte;
        private Button btnBannerAnterior;
    }
}