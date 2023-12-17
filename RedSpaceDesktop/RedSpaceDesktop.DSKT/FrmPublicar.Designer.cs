namespace RedSpaceDesktop.DSKT
{
    partial class FrmPublicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicar));
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.lblInstalador = new System.Windows.Forms.Label();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBanner = new System.Windows.Forms.Button();
            this.btnInstallPath = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.txtInstallPath = new System.Windows.Forms.TextBox();
            this.cbDeveloper = new System.Windows.Forms.ComboBox();
            this.lblExplainId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lbl1.Location = new System.Drawing.Point(276, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(418, 74);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "PUBLICAR JOGO";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnFechar.Location = new System.Drawing.Point(892, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 30);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(134, 164);
            this.txtGame.MaxLength = 50;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(400, 20);
            this.txtGame.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblNome.Location = new System.Drawing.Point(130, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 27);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(134, 323);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblCategory.Location = new System.Drawing.Point(129, 293);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 27);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Categoria:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblDescricao.Location = new System.Drawing.Point(129, 370);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(117, 27);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 400);
            this.txtDescription.MaxLength = 1800;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 267);
            this.txtDescription.TabIndex = 3;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblBanner.Location = new System.Drawing.Point(603, 134);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(88, 27);
            this.lblBanner.TabIndex = 16;
            this.lblBanner.Text = "Banner:";
            // 
            // lblInstalador
            // 
            this.lblInstalador.AutoSize = true;
            this.lblInstalador.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstalador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblInstalador.Location = new System.Drawing.Point(603, 478);
            this.lblInstalador.Name = "lblInstalador";
            this.lblInstalador.Size = new System.Drawing.Size(116, 27);
            this.lblInstalador.TabIndex = 17;
            this.lblInstalador.Text = "Instalador:";
            // 
            // pbBanner
            // 
            this.pbBanner.Location = new System.Drawing.Point(608, 164);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(250, 230);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 20;
            this.pbBanner.TabStop = false;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.Location = new System.Drawing.Point(608, 617);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(120, 50);
            this.btnPublicar.TabIndex = 6;
            this.btnPublicar.Text = "PUBLICAR";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(738, 617);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBanner
            // 
            this.btnBanner.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanner.Location = new System.Drawing.Point(608, 400);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(250, 40);
            this.btnBanner.TabIndex = 4;
            this.btnBanner.Text = "FAZER UPLOAD";
            this.btnBanner.UseVisualStyleBackColor = true;
            this.btnBanner.Click += new System.EventHandler(this.btnBanner_Click);
            // 
            // btnInstallPath
            // 
            this.btnInstallPath.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallPath.Location = new System.Drawing.Point(608, 508);
            this.btnInstallPath.Name = "btnInstallPath";
            this.btnInstallPath.Size = new System.Drawing.Size(250, 40);
            this.btnInstallPath.TabIndex = 5;
            this.btnInstallPath.Text = "CARREGAR ARQUIVO";
            this.btnInstallPath.UseVisualStyleBackColor = true;
            this.btnInstallPath.Click += new System.EventHandler(this.btnInstallPath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 692);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblDeveloper.Location = new System.Drawing.Point(130, 215);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(191, 27);
            this.lblDeveloper.TabIndex = 29;
            this.lblDeveloper.Text = "Desenvolvedor(a):";
            // 
            // txtInstallPath
            // 
            this.txtInstallPath.Enabled = false;
            this.txtInstallPath.Location = new System.Drawing.Point(608, 554);
            this.txtInstallPath.MaxLength = 50;
            this.txtInstallPath.Name = "txtInstallPath";
            this.txtInstallPath.Size = new System.Drawing.Size(250, 20);
            this.txtInstallPath.TabIndex = 30;
            // 
            // cbDeveloper
            // 
            this.cbDeveloper.FormattingEnabled = true;
            this.cbDeveloper.Location = new System.Drawing.Point(134, 245);
            this.cbDeveloper.Name = "cbDeveloper";
            this.cbDeveloper.Size = new System.Drawing.Size(250, 21);
            this.cbDeveloper.TabIndex = 1;
            // 
            // lblExplainId
            // 
            this.lblExplainId.AutoSize = true;
            this.lblExplainId.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplainId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExplainId.Location = new System.Drawing.Point(131, 187);
            this.lblExplainId.Name = "lblExplainId";
            this.lblExplainId.Size = new System.Drawing.Size(307, 17);
            this.lblExplainId.TabIndex = 52;
            this.lblExplainId.Text = "O nome do jogo não deve possuir acentuação.";
            // 
            // FrmPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.lblExplainId);
            this.Controls.Add(this.cbDeveloper);
            this.Controls.Add(this.txtInstallPath);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.btnInstallPath);
            this.Controls.Add(this.btnBanner);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.lblInstalador);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPublicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPublicar";
            this.Load += new System.EventHandler(this.FrmPublicar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Label lblInstalador;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBanner;
        private System.Windows.Forms.Button btnInstallPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.TextBox txtInstallPath;
        private System.Windows.Forms.ComboBox cbDeveloper;
        private System.Windows.Forms.Label lblExplainId;
    }
}