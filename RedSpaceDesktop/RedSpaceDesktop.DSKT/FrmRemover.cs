using RedSpaceDesktop.DAL;
using RedSpaceDesktop.DSKT.Utilities;
using RedSpaceDesktop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSpaceDesktop.DSKT
{
    public partial class FrmRemover : Form
    {
        public FrmRemover()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRemover_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = btnLimpar.Enabled = btnRemover.Enabled = false;
            CarregaDesenvolvedorCBO();
            CarregaCategoriaCBO();
        }

        //objetos globais
        JogoDTO objDel = new JogoDTO();
        JogoDAL objDAL = new JogoDAL();
        UsuarioJogoDAL objHist = new UsuarioJogoDAL();

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
            objDel = objDAL.BuscaJogoPorId(codigo);

            if (objDel == null)
            {
                MessageBox.Show("ID inválido ou inexistente.");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }
            else
            {
                string caminho = @"T:\Publica\TI 19\redspace-web";
                //string caminho = @"C:\Users\wesley.oferreira1\Desktop\redspace-web\";
                //string caminho = @"C:\Users\gianluca.nlima\Desktop\redspace-web\";
                txtGame.Text = objDel.Nome;
                cbDeveloper.SelectedValue = Convert.ToInt32(objDel.IdDesenvolvedor);
                cbCategory.SelectedValue = Convert.ToInt32(objDel.IdCategoria);
                txtDescription.Text = objDel.Descricao;
                txtInstallPath.Text = objDel.InstaladorPath;
                pbBanner.ImageLocation = caminho + objDel.Banner.Replace(".", string.Empty).Replace("png", string.Empty) + ".png";
                btnRemover.Enabled = btnLimpar.Enabled = true;
            }
            txtId.Enabled = btnPesquisar.Enabled = false;
        }

        //permitir somente números
        private void btnPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se for diferente de um número, ou seja, qualquer tipo de caractere ele aplica o true que bloqueia a digitação dos mesmos.
            //o keychar 08 é o código do backspace, deixamos ele liberado para poder usar no campo
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //atribui true no handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtId.Enabled = btnPesquisar.Enabled = true;
            btnRemover.Enabled = btnLimpar.Enabled = false;
            txtId.Focus();
        }

        //remover registro
        private void btnRemover_Click(object sender, EventArgs e)
        {
            //criando variavel para armazenar escolha do usuário
            //deu uma mensagem -> colocou um titúlo -> propôs os botões de arternativa (seráo usados posteriormente no if else o valor) -> apresentou a caixa de mensagem
            DialogResult msg = MessageBox.Show($"Deseja realmente remover do catálogo o jogo {txtGame.Text.ToUpper()}?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido pelo usuário
            if (msg == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(txtId.Text);
                objDAL.ExcluirJogo(codigo);
                objHist.ExcluirUsuarioJogo(codigo);
                MessageBox.Show("Jogo excluído com sucesso!");
                Limpar.ClearControl(this);
                txtId.Enabled = btnPesquisar.Enabled = true;
                btnRemover.Enabled = btnLimpar.Enabled = false;
                txtId.Focus();
            }
            else if (msg == DialogResult.No)
            {
                Limpar.ClearControl(this);
                txtId.Enabled = btnPesquisar.Enabled = true;
                btnRemover.Enabled = btnLimpar.Enabled = false;
                txtId.Focus();
            }
        }
    }
}
