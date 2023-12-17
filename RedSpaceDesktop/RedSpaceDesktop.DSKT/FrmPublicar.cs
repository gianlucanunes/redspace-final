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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSpaceDesktop.DSKT
{
    public partial class FrmPublicar : Form
    {
        public FrmPublicar()
        {
            InitializeComponent();
        }

        //objetos globais
        JogoDTO objPub = new JogoDTO();
        JogoDAL objDAL = new JogoDAL();

        private void CarregaCategoriaCBO()
        {
            cbCategory.ValueMember = "IdCategoria"; //valor que irá passar para o banco
            cbCategory.DisplayMember = "Nome"; //o que é mostrado para o usuário
            cbCategory.DataSource = objDAL.CarregaCategoria().ToList();

        }

        private void CarregaDesenvolvedorCBO()
        {
            cbDeveloper.ValueMember = "IdDesenvolvedor"; //valor que irá passar para o banco
            cbDeveloper.DisplayMember = "Nome"; //o que é mostrado para o usuário
            cbDeveloper.DataSource = objDAL.CarregaDesenvolvedor().ToList();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPublicar_Load(object sender, EventArgs e)
        {
            CarregaDesenvolvedorCBO();
            CarregaCategoriaCBO();
        }

        //imagem de capa do jogo
        private void btnBanner_Click(object sender, EventArgs e)
        {
            //carregando a imagem
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jfif;*.jpeg;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string img = dialog.FileName.ToString();
                pbBanner.ImageLocation = img;

            }
        }

        //arquivo de instalação do jogo
        private void btnInstallPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = "exe";
            dialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                string result;

                result = Path.GetFileNameWithoutExtension(fileName);
                Console.WriteLine("GetFileNameWithoutExtension('{0}') returns '{1}'",
                    fileName, result);

                string textbox = result.ToString();
                txtInstallPath.AppendText(textbox);
            }
        }

        //validação das informações que devem obrigatoriamente ser preenchidas
        public bool validaForm()
        {
            //criando variavel de retorno
            bool validator;

            //estrutura de checagem - a cada if um campo é checado
            if (string.IsNullOrEmpty(txtGame.Text))
            {
                MessageBox.Show("Digite o nome do jogo.");
                txtGame.Focus();
                validator = false; //se recebeu false, há algo errado e o loop volta
            }
            else if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Coloque a descrição do jogo. (1800 caracteres)");
                txtDescription.Focus();
                validator = false;
            }
            else if (pbBanner.Image == null)
            {
                MessageBox.Show("Selecione a imagem de capa do jogo.");
                btnBanner.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtInstallPath.Text))
            {
                MessageBox.Show("Anexe o arquivo executável do jogo.");
                btnInstallPath.Focus();
                validator = false;
            }
            else
            {
                validator = true; //passando por todos os if, será true e dará o return
            }
            return validator;
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                JogoDTO objPub = new JogoDTO();

                //text
                objPub.Nome = txtGame.Text;
                objPub.Descricao = txtDescription.Text;

                //combobox
                objPub.IdDesenvolvedor = cbDeveloper.SelectedValue.ToString();
                objPub.IdCategoria = cbCategory.SelectedValue.ToString();

                //salvando a URL do arquivo
                string nomeInstall = txtGame.Text.Replace(' ', '-') + ".exe";
                var charsToRemove = new string[] { ":", "@", "!", "?" };
                foreach (var c in charsToRemove)
                {
                    nomeInstall = nomeInstall.Replace(c, string.Empty);
                }
                string pastaWebInstall = @"T:\Publica\TI 19\redspace-web\installs\";
                string pastaBancoInstall  = @".\installs\";
                string caminhoBancoInstall = Path.Combine(pastaBancoInstall, nomeInstall);
                string caminhoWebInstall = Path.Combine(pastaWebInstall, nomeInstall);
                objPub.InstaladorPath = caminhoBancoInstall;

                //salvando o executável

                //crie uma instância da classe FileStream
                FileStream fs = new FileStream(caminhoWebInstall, FileMode.Create);

                //crie um objeto StreamWriter para escrever no arquivo
                StreamWriter sw = new StreamWriter(fs);

                //escreva a string no arquivo
                sw.WriteLine(caminhoWebInstall);

                //feche o StreamWriter e FileStream
                sw.Close();
                fs.Close();

                //salvando a URL da imagem
                string nomeImg = txtGame.Text.Replace(' ', '-') + ".png";
                foreach (var c in charsToRemove)
                {
                    nomeImg = nomeImg.Replace(c, string.Empty);
                }
                string pastaWebImg = @"T:\Publica\TI 19\redspace-web\img\";
                //string pastaWeb = @"C:\Users\gianluca.nlima\Desktop\redspace-web\img\";
                //string pastaWeb = @"C:\Users\wesley.oferreira1\Desktop\redspace-web\img\";
                string pastaBancoImg = @".\img\";
                string caminhoBancoImg = Path.Combine(pastaBancoImg, nomeImg);
                string caminhoWebImg = Path.Combine(pastaWebImg, nomeImg);
                objPub.Banner = caminhoBancoImg;

                //salvando na pasta
                Image banner = pbBanner.Image;
                banner.Save(caminhoWebImg);

                //data
                objPub.DtLancamento = DateTime.Now;

                JogoDAL objDAL = new JogoDAL();
                objDAL.CadastrarJogo(objPub);
                Limpar.ClearControl(this);

                MessageBox.Show("O jogo " + objPub.Nome + " foi publicado com sucesso no RedSpace!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtGame.Focus();
        }
    }
}
