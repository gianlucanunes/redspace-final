namespace RedSpaceDesktop.DSKT
{
    partial class FrmCadastrar
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblExplainSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDiscord = new System.Windows.Forms.TextBox();
            this.lblDiscord = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lbl1.Location = new System.Drawing.Point(115, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(746, 74);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "CADASTRAR DESENVOLVEDOR";
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
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(115, 193);
            this.txtDeveloper.MaxLength = 50;
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(400, 20);
            this.txtDeveloper.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblNome.Location = new System.Drawing.Point(111, 163);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 27);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblSenha.Location = new System.Drawing.Point(111, 247);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(79, 27);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 277);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblExplainSenha
            // 
            this.lblExplainSenha.AutoSize = true;
            this.lblExplainSenha.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplainSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExplainSenha.Location = new System.Drawing.Point(113, 300);
            this.lblExplainSenha.Name = "lblExplainSenha";
            this.lblExplainSenha.Size = new System.Drawing.Size(467, 16);
            this.lblExplainSenha.TabIndex = 10;
            this.lblExplainSenha.Text = "Senha que será usada pelo desenvolvdor para acessar sua página e publicar jogos.";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 363);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblEmail.Location = new System.Drawing.Point(112, 333);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 27);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(395, 651);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(114, 651);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 50);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDiscord
            // 
            this.txtDiscord.Location = new System.Drawing.Point(118, 576);
            this.txtDiscord.MaxLength = 50;
            this.txtDiscord.Name = "txtDiscord";
            this.txtDiscord.Size = new System.Drawing.Size(300, 20);
            this.txtDiscord.TabIndex = 5;
            // 
            // lblDiscord
            // 
            this.lblDiscord.AutoSize = true;
            this.lblDiscord.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblDiscord.Location = new System.Drawing.Point(114, 552);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(71, 21);
            this.lblDiscord.TabIndex = 28;
            this.lblDiscord.Text = "Discord:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(117, 523);
            this.txtInstagram.MaxLength = 50;
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(300, 20);
            this.txtInstagram.TabIndex = 4;
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblInstagram.Location = new System.Drawing.Point(113, 499);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(90, 21);
            this.lblInstagram.TabIndex = 26;
            this.lblInstagram.Text = "Instagram:";
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(118, 472);
            this.txtTwitter.MaxLength = 50;
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(300, 20);
            this.txtTwitter.TabIndex = 3;
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblTwitter.Location = new System.Drawing.Point(113, 448);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(67, 21);
            this.lblTwitter.TabIndex = 24;
            this.lblTwitter.Text = "Twitter:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RedSpaceDesktop.DSKT.Properties.Resources.rocket_redspace1;
            this.pictureBox1.Location = new System.Drawing.Point(383, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(114, 410);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 22);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "REDES SOCIAIS";
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtDiscord);
            this.Controls.Add(this.lblDiscord);
            this.Controls.Add(this.txtInstagram);
            this.Controls.Add(this.lblInstagram);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblExplainSenha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblExplainSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDiscord;
        private System.Windows.Forms.Label lblDiscord;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.Label lbl2;
    }
}