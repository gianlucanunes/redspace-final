using RedSpaceDesktop.DAL;
using RedSpaceDesktop.DSKT.Utilities;
using RedSpaceDesktop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSpaceDesktop.DSKT
{
    public partial class FrmAdicionar : Form
    {
        public FrmAdicionar()
        {
            InitializeComponent();
        }

        //objetos globais
        GaleriaDTO objAdd = new GaleriaDTO();
        GaleriaDAL galeriaDAL = new GaleriaDAL();
        JogoDTO jogoDTO = new JogoDTO();
        JogoDAL jogoDAL = new JogoDAL();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = btnSalvar.Enabled = btnLimpar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite o ID.");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }

            int codigo;
            int.TryParse(txtId.Text, out codigo);
            jogoDTO = jogoDAL.BuscaJogoPorId(codigo);

            if (jogoDTO == null)
            {
                MessageBox.Show("ID inválido ou inexistente.");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }
            else
            {
                txtGame.Text = jogoDTO.Nome.ToString();
                string caminho = @"T:\Publica\TI 19\redspace-web\";
                pbBanner.ImageLocation = caminho + jogoDTO.Banner.Replace("..", string.Empty);
                gBox1.Enabled = btnSalvar.Enabled = btnLimpar.Enabled = true;
                txtId.Enabled = btnPesquisar.Enabled = false;
                //imagens
                btnImagem1.Enabled = true;
                btnImagem2.Enabled = btnImagem3.Enabled = btnImagem4.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            gBox1.Enabled = btnSalvar.Enabled = btnLimpar.Enabled = false;
            txtId.Enabled = btnPesquisar.Enabled = true;
            txtId.Focus();
        }

        //PRIMEIRA IMAGEM
        private void btnImagem1_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery1.ImageLocation = img;

                btnImagem2.Enabled = true;
            }
        }

        //SEGUNDA IMAGEM
        private void btnImagem2_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery2.ImageLocation = img;

                btnImagem3.Enabled = true;
            }
        }

        //TERCEIRA IMAGEM
        private void btnImagem3_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery3.ImageLocation = img;

                btnImagem4.Enabled = true;
            }
        }

        //QUARTA IMAGEM
        private void btnImagem4_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery4.ImageLocation = img;
            }
        }

        public bool validaForm()
        {
            //criando variavel de retorno
            bool validator;

            //estrutura de checagem - a cada if um campo é checado
            if (pbGalery1.Image == null || pbGalery2.Image == null || pbGalery3.Image == null || pbGalery4.Image == null)
            {
                MessageBox.Show("Por favor, selecione as quatro imagens.");
                btnImagem1.Focus();
                validator = false;
            }
            else
            {
                validator = true; //passando por todos os if, será true e dará o return
            }
            return validator;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
            GaleriaDTO objAdd1 = new GaleriaDTO();
            GaleriaDTO objAdd2 = new GaleriaDTO();
            GaleriaDTO objAdd3 = new GaleriaDTO();
            GaleriaDTO objAdd4 = new GaleriaDTO();

            objAdd1.IdJogo = txtId.Text;
            objAdd2.IdJogo = txtId.Text;
            objAdd3.IdJogo = txtId.Text;
            objAdd4.IdJogo = txtId.Text;

            //salvando a URL da imagem

            //nomeando cada tela
            string nomeImg1 = txtId.Text + "tela1.png";
            string nomeImg2 = txtId.Text + "tela2.png";
            string nomeImg3 = txtId.Text + "tela3.png";
            string nomeImg4 = txtId.Text + "tela4.png";

            //pastas
            string pastaWebImg = @"T:\Publica\TI 19\redspace-web\img\";
            string pastaBancoImg = @".\img\";

            //caminhos

            //1
            string caminhoBancoImg1 = Path.Combine(pastaBancoImg, nomeImg1);
            string caminhoWebImg1 = Path.Combine(pastaWebImg, nomeImg1);
            //2
            string caminhoBancoImg2 = Path.Combine(pastaBancoImg, nomeImg2);
            string caminhoWebImg2 = Path.Combine(pastaWebImg, nomeImg2);
            //3
            string caminhoBancoImg3 = Path.Combine(pastaBancoImg, nomeImg3);
            string caminhoWebImg3 = Path.Combine(pastaWebImg, nomeImg3);
            //4
            string caminhoBancoImg4 = Path.Combine(pastaBancoImg, nomeImg4);
            string caminhoWebImg4 = Path.Combine(pastaWebImg, nomeImg4);

            //atribuindo ao seus objetos
            objAdd1.FotoPath = caminhoBancoImg1;
            objAdd2.FotoPath = caminhoBancoImg2;
            objAdd3.FotoPath = caminhoBancoImg3;
            objAdd4.FotoPath = caminhoBancoImg4;

            //salvando na pasta
            Image tela1 = pbGalery1.Image;
            tela1.Save(caminhoWebImg1);

            Image tela2 = pbGalery2.Image;
            tela2.Save(caminhoWebImg2);

            Image tela3 = pbGalery3.Image;
            tela3.Save(caminhoWebImg3);

            Image tela4 = pbGalery4.Image;
            tela4.Save(caminhoWebImg4);

            //adicionando
            GaleriaDAL galeriaDAL = new GaleriaDAL();
            galeriaDAL.CadastrarGaleria(objAdd1);
            galeriaDAL.CadastrarGaleria(objAdd2);
            galeriaDAL.CadastrarGaleria(objAdd3);
            galeriaDAL.CadastrarGaleria(objAdd4);

            Limpar.ClearControl(this);

            MessageBox.Show("A galeria do jogo " + jogoDTO.Nome + " foi adicionada com sucesso!");
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
