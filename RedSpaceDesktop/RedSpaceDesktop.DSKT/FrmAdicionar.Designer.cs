namespace RedSpaceDesktop.DSKT
{
    partial class FrmAdicionar
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
            this.pbGalery4 = new System.Windows.Forms.PictureBox();
            this.pbGalery3 = new System.Windows.Forms.PictureBox();
            this.pbGalery2 = new System.Windows.Forms.PictureBox();
            this.pbGalery1 = new System.Windows.Forms.PictureBox();
            this.btnImagem1 = new System.Windows.Forms.Button();
            this.btnImagem2 = new System.Windows.Forms.Button();
            this.btnImagem3 = new System.Windows.Forms.Button();
            this.btnImagem4 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery1)).BeginInit();
            this.gBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lbl1.Location = new System.Drawing.Point(223, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(531, 74);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "ADICIONAR GALERIA";
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
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Location = new System.Drawing.Point(38, 241);
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
            this.lblExplainId.Location = new System.Drawing.Point(35, 213);
            this.lblExplainId.Name = "lblExplainId";
            this.lblExplainId.Size = new System.Drawing.Size(237, 16);
            this.lblExplainId.TabIndex = 21;
            this.lblExplainId.Text = "Digite o ID do JOGO para liberar a edição.";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(38, 190);
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
            this.lblId.Location = new System.Drawing.Point(33, 160);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 27);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "ID:";
            // 
            // pbGalery4
            // 
            this.pbGalery4.Location = new System.Drawing.Point(359, 271);
            this.pbGalery4.Name = "pbGalery4";
            this.pbGalery4.Size = new System.Drawing.Size(310, 180);
            this.pbGalery4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGalery4.TabIndex = 48;
            this.pbGalery4.TabStop = false;
            // 
            // pbGalery3
            // 
            this.pbGalery3.Location = new System.Drawing.Point(15, 271);
            this.pbGalery3.Name = "pbGalery3";
            this.pbGalery3.Size = new System.Drawing.Size(310, 180);
            this.pbGalery3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGalery3.TabIndex = 47;
            this.pbGalery3.TabStop = false;
            // 
            // pbGalery2
            // 
            this.pbGalery2.Location = new System.Drawing.Point(359, 17);
            this.pbGalery2.Name = "pbGalery2";
            this.pbGalery2.Size = new System.Drawing.Size(310, 180);
            this.pbGalery2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGalery2.TabIndex = 46;
            this.pbGalery2.TabStop = false;
            // 
            // pbGalery1
            // 
            this.pbGalery1.Location = new System.Drawing.Point(15, 17);
            this.pbGalery1.Name = "pbGalery1";
            this.pbGalery1.Size = new System.Drawing.Size(310, 180);
            this.pbGalery1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGalery1.TabIndex = 45;
            this.pbGalery1.TabStop = false;
            // 
            // btnImagem1
            // 
            this.btnImagem1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem1.Location = new System.Drawing.Point(15, 203);
            this.btnImagem1.Name = "btnImagem1";
            this.btnImagem1.Size = new System.Drawing.Size(310, 30);
            this.btnImagem1.TabIndex = 2;
            this.btnImagem1.Text = "ESCOLHER IMAGEM 1";
            this.btnImagem1.UseVisualStyleBackColor = true;
            this.btnImagem1.Click += new System.EventHandler(this.btnImagem1_Click);
            // 
            // btnImagem2
            // 
            this.btnImagem2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem2.Location = new System.Drawing.Point(359, 203);
            this.btnImagem2.Name = "btnImagem2";
            this.btnImagem2.Size = new System.Drawing.Size(310, 30);
            this.btnImagem2.TabIndex = 3;
            this.btnImagem2.Text = "ESCOLHER IMAGEM 2";
            this.btnImagem2.UseVisualStyleBackColor = true;
            this.btnImagem2.Click += new System.EventHandler(this.btnImagem2_Click);
            // 
            // btnImagem3
            // 
            this.btnImagem3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem3.Location = new System.Drawing.Point(15, 457);
            this.btnImagem3.Name = "btnImagem3";
            this.btnImagem3.Size = new System.Drawing.Size(310, 30);
            this.btnImagem3.TabIndex = 4;
            this.btnImagem3.Text = "ESCOLHER IMAGEM 3";
            this.btnImagem3.UseVisualStyleBackColor = true;
            this.btnImagem3.Click += new System.EventHandler(this.btnImagem3_Click);
            // 
            // btnImagem4
            // 
            this.btnImagem4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem4.Location = new System.Drawing.Point(359, 457);
            this.btnImagem4.Name = "btnImagem4";
            this.btnImagem4.Size = new System.Drawing.Size(310, 30);
            this.btnImagem4.TabIndex = 5;
            this.btnImagem4.Text = "ESCOLHER IMAGEM 4";
            this.btnImagem4.UseVisualStyleBackColor = true;
            this.btnImagem4.Click += new System.EventHandler(this.btnImagem4_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(353, 671);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 50);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtGame
            // 
            this.txtGame.Enabled = false;
            this.txtGame.Location = new System.Drawing.Point(38, 432);
            this.txtGame.MaxLength = 50;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(170, 20);
            this.txtGame.TabIndex = 54;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.lblGame.Location = new System.Drawing.Point(33, 402);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(62, 27);
            this.lblGame.TabIndex = 55;
            this.lblGame.Text = "Jogo:";
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.btnImagem4);
            this.gBox1.Controls.Add(this.btnImagem3);
            this.gBox1.Controls.Add(this.btnImagem2);
            this.gBox1.Controls.Add(this.btnImagem1);
            this.gBox1.Controls.Add(this.pbGalery4);
            this.gBox1.Controls.Add(this.pbGalery3);
            this.gBox1.Controls.Add(this.pbGalery2);
            this.gBox1.Controls.Add(this.pbGalery1);
            this.gBox1.Location = new System.Drawing.Point(280, 151);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(686, 502);
            this.gBox1.TabIndex = 56;
            this.gBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(691, 671);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pbBanner
            // 
            this.pbBanner.Enabled = false;
            this.pbBanner.Location = new System.Drawing.Point(38, 458);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(170, 180);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 58;
            this.pbBanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(350, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "ESCOLHA QUATRO IMAGENS (OBRIGATÓRIO)";
            // 
            // FrmAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gBox1);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblExplainId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdicionar";
            this.Load += new System.EventHandler(this.FrmAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalery1)).EndInit();
            this.gBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
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
        private System.Windows.Forms.PictureBox pbGalery1;
        private System.Windows.Forms.PictureBox pbGalery2;
        private System.Windows.Forms.PictureBox pbGalery3;
        private System.Windows.Forms.PictureBox pbGalery4;
        private System.Windows.Forms.Button btnImagem1;
        private System.Windows.Forms.Button btnImagem2;
        private System.Windows.Forms.Button btnImagem3;
        private System.Windows.Forms.Button btnImagem4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Label label1;
    }
}