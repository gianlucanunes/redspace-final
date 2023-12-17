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
    public partial class FrmExcluir : Form
    {
        public FrmExcluir()
        {
            InitializeComponent();
        }

        //objetos globais
        DesenvolvedorDTO objDel = new DesenvolvedorDTO();
        DesenvolvedorDAL objDAL = new DesenvolvedorDAL();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmExcluir_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = btnLimpar.Enabled = btnExcluir.Enabled = false;
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
            objDel = objDAL.BuscarDesenvolvedorPorID(codigo);

            if (objDel == null)
            {
                MessageBox.Show("ID inválido ou inexistente.");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }
            else
            {
                txtDeveloper.Text = objDel.Nome;
                txtPassword.Text = objDel.Senha;
                txtEmail.Text = objDel.Email;
                txtTwitter.Text = objDel.Twitter;
                txtInstagram.Text = objDel.Instagram;
                txtDiscord.Text = objDel.Discord;
                btnExcluir.Enabled = btnLimpar.Enabled = true;
            }
            txtId.Enabled = btnPesquisar.Enabled = false;
        }

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtId.Enabled = btnPesquisar.Enabled = true;
            btnExcluir.Enabled = btnLimpar.Enabled = false;
            txtId.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //criando variavel para armazenar escolha do usuário
            //deu uma mensagem -> colocou um titúlo -> propôs os botões de arternativa (seráo usados posteriormente no if else o valor) -> apresentou a caixa de mensagem
            DialogResult msg = MessageBox.Show($"Deseja realmente excluir o(a) Desenvolvedor(a) {txtDeveloper.Text.ToUpper()}?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //manipulando o valor escolhido pelo usuário
            if (msg == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(txtId.Text);
                objDAL.ExcluirDesenvolvedor(codigo);
                MessageBox.Show("Desenvolvedor(a) excluído(a) com sucesso!");
                Limpar.ClearControl(this);
                txtId.Enabled = btnPesquisar.Enabled = true;
                btnExcluir.Enabled = btnLimpar.Enabled = false;
                txtId.Focus();
            }
            else if (msg == DialogResult.No)
            {
                Limpar.ClearControl(this);
                txtId.Enabled = btnPesquisar.Enabled = true;
                btnExcluir.Enabled = btnLimpar.Enabled = false;
                txtId.Focus();
            }
        }
    }
}
