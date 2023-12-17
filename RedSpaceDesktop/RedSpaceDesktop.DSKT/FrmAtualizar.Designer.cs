namespace RedSpaceDesktop.DSKT
{
    partial class FrmAtualizar
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblExplainId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cbDeveloper = new System.Windows.Forms.ComboBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.btnBanner = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.gBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lbl1.Location = new System.Drawing.Point(52, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(895, 74);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "ATUALIZAR INFORMAÇÕES DE JOGO";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.btnFechar.Location = new System.Drawing.Point(908, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 30);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(26, 248);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 40);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblExplainId
            // 
            this.lblExplainId.AutoSize = true;
            this.lblExplainId.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplainId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExplainId.Location = new System.Drawing.Point(23, 217);
            this.lblExplainId.Name = "lblExplainId";
            this.lblExplainId.Size = new System.Drawing.Size(185, 16);
            this.lblExplainId.TabIndex = 17;
            this.lblExplainId.Text = "Digite o ID para liberar a edição.";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(25, 194);
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
            this.lblId.Location = new System.Drawing.Point(21, 164);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 27);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "ID:";
            // 
            // cbDeveloper
            // 
            this.cbDeveloper.FormattingEnabled = true;
            this.cbDeveloper.Location = new System.Drawing.Point(15, 113);
            this.cbDeveloper.Name = "cbDeveloper";
            this.cbDeveloper.Size = new System.Drawing.Size(250, 21);
            this.cbDeveloper.TabIndex = 3;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblDeveloper.Location = new System.Drawing.Point(11, 83);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(191, 27);
            this.lblDeveloper.TabIndex = 45;
            this.lblDeveloper.Text = "Desenvolvedor(a):";
            // 
            // btnBanner
            // 
            this.btnBanner.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanner.Location = new System.Drawing.Point(489, 479);
            this.btnBanner.Name = "btnBanner";
            this.btnBanner.Size = new System.Drawing.Size(250, 40);
            this.btnBanner.TabIndex = 6;
            this.btnBanner.Text = "FAZER UPLOAD";
            this.btnBanner.UseVisualStyleBackColor = true;
            this.btnBanner.Click += new System.EventHandler(this.btnBanner_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(772, 714);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(217, 714);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 50);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbBanner
            // 
            this.pbBanner.Location = new System.Drawing.Point(489, 243);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(250, 230);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 44;
            this.pbBanner.TabStop = false;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblBanner.Location = new System.Drawing.Point(484, 213);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(88, 27);
            this.lblBanner.TabIndex = 42;
            this.lblBanner.Text = "Banner:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 252);
            this.txtDescription.MaxLength = 1800;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 267);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblDescricao.Location = new System.Drawing.Point(11, 222);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(117, 27);
            this.lblDescricao.TabIndex = 41;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblCategory.Location = new System.Drawing.Point(11, 151);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 27);
            this.lblCategory.TabIndex = 40;
            this.lblCategory.Text = "Categoria:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(16, 181);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 4;
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(15, 42);
            this.txtGame.MaxLength = 50;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(400, 20);
            this.txtGame.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblNome.Location = new System.Drawing.Point(11, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 27);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.cbDeveloper);
            this.gBox1.Controls.Add(this.lblDeveloper);
            this.gBox1.Controls.Add(this.btnBanner);
            this.gBox1.Controls.Add(this.pbBanner);
            this.gBox1.Controls.Add(this.lblBanner);
            this.gBox1.Controls.Add(this.txtDescription);
            this.gBox1.Controls.Add(this.lblDescricao);
            this.gBox1.Controls.Add(this.lblCategory);
            this.gBox1.Controls.Add(this.cbCategory);
            this.gBox1.Controls.Add(this.txtGame);
            this.gBox1.Controls.Add(this.lblNome);
            this.gBox1.Location = new System.Drawing.Point(217, 152);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(755, 537);
            this.gBox1.TabIndex = 47;
            this.gBox1.TabStop = false;
            // 
            // FrmAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblExplainId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAtualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAtualizar";
            this.Load += new System.EventHandler(this.FrmAtualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblExplainId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button btnBanner;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gBox1;
    }
}