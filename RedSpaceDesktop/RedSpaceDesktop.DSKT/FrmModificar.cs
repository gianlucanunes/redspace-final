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
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
        }

        //objetos globais
        GaleriaDAL galeriaDAL = new GaleriaDAL();
        JogoDTO jogoDTO = new JogoDTO();
        JogoDAL jogoDAL = new JogoDAL();
        bool telaNova1;
        bool telaNova2;
        bool telaNova3;
        bool telaNova4;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = btnSalvar.Enabled = btnEditar.Enabled = false;
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
                btnEditar.Enabled = true;
                txtId.Enabled = btnPesquisar.Enabled = false;
                //imagens
                pbGalery1.ImageLocation = caminho + @"\img\" + txtId.Text + "tela1.png";
                pbGalery2.ImageLocation = caminho + @"\img\" + txtId.Text + "tela2.png";
                pbGalery3.ImageLocation = caminho + @"\img\" + txtId.Text + "tela3.png";
                pbGalery4.ImageLocation = caminho + @"\img\" + txtId.Text + "tela4.png";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gBox1.Enabled = btnSalvar.Enabled = true;
            btnPesquisar.Enabled = txtId.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GaleriaDTO objMod = new GaleriaDTO();

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

            var listaGaleria = galeriaDAL.BuscaGaleriaPorJogo(Convert.ToInt32(txtId.Text));
            int telaAtual = 1;
            listaGaleria.ForEach(galeria =>
            {
                GaleriaDTO objModEach = new GaleriaDTO();
                int idGaleria = galeria.IdGaleria;
                if (telaAtual == 1 && telaNova1 == true)
                {
                    string caminhoAntigo = Path.Combine(pastaWebImg, galeria.FotoPath.Replace(".", string.Empty).Replace("png", string.Empty).Replace(@"\img\", string.Empty) + ".png");
                    if (File.Exists(caminhoAntigo))
                    {
                        File.Delete(caminhoAntigo);
                    }

                    galeria.FotoPath = caminhoBancoImg1;

                    objModEach.FotoPath = galeria.FotoPath;
                    objModEach.IdGaleria = idGaleria;
                    galeriaDAL.EditarGaleria(objModEach);

                    //pasta
                    Image tela1 = pbGalery1.Image;
                    tela1.Save(caminhoWebImg1);
                }
                else if (telaAtual == 2 && telaNova2 == true)
                {
                    string caminhoAntigo = Path.Combine(pastaWebImg, galeria.FotoPath.Replace(".", string.Empty).Replace("png", string.Empty).Replace(@"\img\", string.Empty) + ".png");
                    if (File.Exists(caminhoAntigo))
                    {
                        File.Delete(caminhoAntigo);
                    }

                    galeria.FotoPath = caminhoBancoImg2;

                    objModEach.FotoPath = galeria.FotoPath;
                    objModEach.IdGaleria = idGaleria;
                    galeriaDAL.EditarGaleria(objModEach);

                    //pasta
                    Image tela2 = pbGalery2.Image;
                    tela2.Save(caminhoWebImg2);
                }
                else if (telaAtual == 3 && telaNova3 == true)
                {
                    string caminhoAntigo = Path.Combine(pastaWebImg, galeria.FotoPath.Replace(".", string.Empty).Replace("png", string.Empty).Replace(@"\img\", string.Empty) + ".png");
                    if (File.Exists(caminhoAntigo))
                    {
                        File.Delete(caminhoAntigo);
                    }

                    galeria.FotoPath = caminhoBancoImg3;

                    objModEach.FotoPath = galeria.FotoPath;
                    objModEach.IdGaleria = idGaleria;
                    galeriaDAL.EditarGaleria(objModEach);

                    //pasta
                    Image tela3 = pbGalery3.Image;
                    tela3.Save(caminhoWebImg3);
                }
                else if (telaAtual == 4 && telaNova4 == true)
                {
                    string caminhoAntigo = Path.Combine(pastaWebImg, galeria.FotoPath.Replace(".", string.Empty).Replace("png", string.Empty).Replace(@"\img\", string.Empty) + ".png");
                    if (File.Exists(caminhoAntigo))
                    {
                        File.Delete(caminhoAntigo);
                    }

                    galeria.FotoPath = caminhoBancoImg4;

                    objModEach.FotoPath = galeria.FotoPath;
                    objModEach.IdGaleria = idGaleria;
                    galeriaDAL.EditarGaleria(objModEach);

                    //pasta
                    Image tela4 = pbGalery4.Image;
                    tela4.Save(caminhoWebImg4);
                }
                telaAtual++;
            });

            Limpar.ClearControl(this);
            btnPesquisar.Enabled = txtId.Enabled = true;
            gBox1.Enabled = btnSalvar.Enabled = btnEditar.Enabled = false;

            MessageBox.Show("A galeria do jogo " + jogoDTO.Nome + " foi modificada com sucesso!");
        }

        private void btnImagem1_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery1.ImageLocation = img;
                telaNova1 = true;
            }
        }

        private void btnImagem2_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery2.ImageLocation = img;
                telaNova2 = true;
            }
        }

        private void btnImagem3_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery3.ImageLocation = img;
                telaNova3 = true;
            }
        }

        private void btnImagem4_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbGalery4.ImageLocation = img;
                telaNova4 = true;
            }
        }
    }
}
