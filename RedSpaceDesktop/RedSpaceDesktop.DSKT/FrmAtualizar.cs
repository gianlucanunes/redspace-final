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
    public partial class FrmAtualizar : Form
    {
        public FrmAtualizar()
        {
            InitializeComponent();
        }

        private void FrmAtualizar_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            CarregaDesenvolvedorCBO();
            CarregaCategoriaCBO();
        }

        //objetos globais
        JogoDTO objAtt = new JogoDTO();
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
            else
            {
                validator = true; //passando por todos os if, será true e dará o return
            }
            return validator;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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
            objAtt = objDAL.BuscaJogoPorId(codigo);

            if (objAtt == null)
            {
                MessageBox.Show("ID inválido ou inexistente.");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }
            else
            {
                string caminho = @"T:\Publica\TI 19\redspace-web\";
                //string caminho = @"C:\Users\wesley.oferreira1\Desktop\redspace-web\";
                //string caminho = @"C:\Users\gianluca.nlima\Desktop\redspace-web\";
                txtGame.Text = objAtt.Nome;
                cbDeveloper.SelectedValue = Convert.ToInt32(objAtt.IdDesenvolvedor);
                cbCategory.SelectedValue = Convert.ToInt32(objAtt.IdCategoria);
                txtDescription.Text = objAtt.Descricao;
                pbBanner.ImageLocation = caminho + objAtt.Banner.Replace("..", string.Empty);
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gBox1.Enabled = true;
            btnSalvar.Enabled = true;
            txtId.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                JogoDTO objAtt = new JogoDTO();

                objAtt = objDAL.BuscaJogoPorId(Convert.ToInt32(txtId.Text));

                objAtt.IdJogo = Convert.ToInt32(txtId.Text);

                //text
                objAtt.Nome = txtGame.Text;
                objAtt.Descricao = txtDescription.Text;

                //combobox
                objAtt.IdDesenvolvedor = cbDeveloper.SelectedValue.ToString();
                objAtt.IdCategoria = cbCategory.SelectedValue.ToString();

                //salvando a URL da imagem
                string nomeImg = txtGame.Text.Replace(' ', '-') + ".png";
                var charsToRemove = new string[] { ":", "@", "!", "?" };
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

                string caminhoAntigo = Path.Combine(pastaWebImg, objAtt.Banner.Replace(".", string.Empty).Replace("png", string.Empty).Replace(@"\img\", string.Empty) + ".png");
                if (File.Exists(caminhoAntigo))
                {
                    File.Delete(caminhoAntigo);
                }

                objAtt.Banner = caminhoBancoImg;

                //salvando na pasta
                Image banner = pbBanner.Image;
                banner.Save(caminhoWebImg);

                //editando
                objDAL.EditarJogo(objAtt);
                Limpar.ClearControl(this);
                txtId.Enabled = true;
                txtId.Focus();
                btnPesquisar.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                gBox1.Enabled = false;
                MessageBox.Show($"As informações do jogo {objAtt.Nome} foram atualizadas com sucesso!");
            }
        }

        //usando a variavel para eventos e argumentos do uso do teclado
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se for diferente de um número, ou seja, qualquer tipo de caractere ele aplica o true que bloqueia a digitação dos mesmos.
            //o keychar 08 é o código do backspace, deixamos ele liberado para poder usar no campo
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //atribui true no handled para cancelar o evento
                e.Handled = true;
            }
        }

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
    }
}
