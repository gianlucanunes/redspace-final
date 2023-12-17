namespace RedSpaceDesktop.DSKT
{
    partial class FrmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditar));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblExplainId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtDiscord = new System.Windows.Forms.TextBox();
            this.lblDiscord = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lbl1.Location = new System.Drawing.Point(173, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(635, 74);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "EDITAR DESENVOLVEDOR";
            // 
            // lblExplainId
            // 
            this.lblExplainId.AutoSize = true;
            this.lblExplainId.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplainId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExplainId.Location = new System.Drawing.Point(98, 217);
            this.lblExplainId.Name = "lblExplainId";
            this.lblExplainId.Size = new System.Drawing.Size(185, 16);
            this.lblExplainId.TabIndex = 13;
            this.lblExplainId.Text = "Digite o ID para liberar a edição.";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 194);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 0;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblId.Location = new System.Drawing.Point(96, 164);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 27);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(29, 261);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 22);
            this.lbl2.TabIndex = 44;
            this.lbl2.Text = "REDES SOCIAIS";
            // 
            // txtDiscord
            // 
            this.txtDiscord.Location = new System.Drawing.Point(33, 427);
            this.txtDiscord.MaxLength = 50;
            this.txtDiscord.Name = "txtDiscord";
            this.txtDiscord.Size = new System.Drawing.Size(300, 20);
            this.txtDiscord.TabIndex = 7;
            // 
            // lblDiscord
            // 
            this.lblDiscord.AutoSize = true;
            this.lblDiscord.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblDiscord.Location = new System.Drawing.Point(29, 403);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(71, 21);
            this.lblDiscord.TabIndex = 43;
            this.lblDiscord.Text = "Discord:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(32, 374);
            this.txtInstagram.MaxLength = 50;
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(300, 20);
            this.txtInstagram.TabIndex = 6;
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblInstagram.Location = new System.Drawing.Point(28, 350);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(90, 21);
            this.lblInstagram.TabIndex = 42;
            this.lblInstagram.Text = "Instagram:";
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(33, 323);
            this.txtTwitter.MaxLength = 50;
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(300, 20);
            this.txtTwitter.TabIndex = 5;
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblTwitter.Location = new System.Drawing.Point(28, 299);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(67, 21);
            this.lblTwitter.TabIndex = 41;
            this.lblTwitter.Text = "Twitter:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(754, 652);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 50);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(473, 652);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 50);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 214);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblEmail.Location = new System.Drawing.Point(27, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 27);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(30, 128);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblSenha.Location = new System.Drawing.Point(26, 98);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(79, 27);
            this.lblSenha.TabIndex = 38;
            this.lblSenha.Text = "Senha:";
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(30, 44);
            this.txtDeveloper.MaxLength = 50;
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(400, 20);
            this.txtDeveloper.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblNome.Location = new System.Drawing.Point(26, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 27);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(101, 248);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 40);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.lbl2);
            this.gBox1.Controls.Add(this.txtDiscord);
            this.gBox1.Controls.Add(this.lblDiscord);
            this.gBox1.Controls.Add(this.txtInstagram);
            this.gBox1.Controls.Add(this.lblInstagram);
            this.gBox1.Controls.Add(this.txtTwitter);
            this.gBox1.Controls.Add(this.lblTwitter);
            this.gBox1.Controls.Add(this.txtEmail);
            this.gBox1.Controls.Add(this.lblEmail);
            this.gBox1.Controls.Add(this.txtPassword);
            this.gBox1.Controls.Add(this.lblSenha);
            this.gBox1.Controls.Add(this.txtDeveloper);
            this.gBox1.Controls.Add(this.lblNome);
            this.gBox1.Location = new System.Drawing.Point(444, 150);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(459, 470);
            this.gBox1.TabIndex = 46;
            this.gBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblExplainId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditar";
            this.Load += new System.EventHandler(this.FrmEditar_Load);
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblExplainId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtDiscord;
        private System.Windows.Forms.Label lblDiscord;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}