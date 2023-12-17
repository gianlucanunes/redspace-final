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
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        //objetos globais
        DesenvolvedorDTO objEdit = new DesenvolvedorDTO();
        DesenvolvedorDAL objDAL = new DesenvolvedorDAL();

        //validação das informações que devem obrigatoriamente ser preenchidas
        public bool validaForm()
        {
            //criando variavel de retorno
            bool validator;

            //estrutura de checagem - a cada if um campo é checado
            if (string.IsNullOrEmpty(txtDeveloper.Text))
            {
                MessageBox.Show("Digite o nome do(a) desenvolvedor(a)!");
                txtDeveloper.Focus();
                validator = false; //se recebeu false, há algo errado e o loop volta
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Digite a senha que será atribuída ao(a) desenvolvedor(a)!");
                txtPassword.Focus();
                validator = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Digite o e-mail do(a) desenvolvedor(a)!");
                txtEmail.Focus();
                validator = false;
            }
            //as redes sociais não são obrigatórias. logo, não necessitam ser validadas.
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
            objEdit = objDAL.BuscarDesenvolvedorPorID(codigo);

            if (objEdit == null)
            {
                MessageBox.Show("ID inválido ou inexistente.");
                txtId.Text = string.Empty;
                txtId.Focus();
                return;
            }
            else
            {
                txtDeveloper.Text = objEdit.Nome;
                txtPassword.Text = objEdit.Senha;
                txtEmail.Text = objEdit.Email;
                txtTwitter.Text = objEdit.Twitter;
                txtInstagram.Text = objEdit.Instagram;
                txtDiscord.Text = objEdit.Discord;
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
                DesenvolvedorDTO objEdit = new DesenvolvedorDTO();

                objEdit.IdDesenvolvedor = Convert.ToInt32(txtId.Text);

                objEdit.Nome = txtDeveloper.Text;
                objEdit.Senha = txtPassword.Text;
                objEdit.Email = txtEmail.Text;
                objEdit.Twitter = txtTwitter.Text;
                objEdit.Instagram = txtInstagram.Text;
                objEdit.Discord = txtDiscord.Text;

                //editando
                objDAL.EditarDesenvolvedor(objEdit);
                Limpar.ClearControl(this);
                txtId.Enabled = true;
                txtId.Focus();
                btnPesquisar.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                gBox1.Enabled = false;
                MessageBox.Show($"Desenvolvedor(a) {objEdit.Nome} editado com sucesso!");
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

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
        }
    }
}
