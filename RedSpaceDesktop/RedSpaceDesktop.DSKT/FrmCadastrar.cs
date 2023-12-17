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
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        //objetos globais
        DesenvolvedorDTO objCad = new DesenvolvedorDTO();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validaForm())
            {
                //preencher dados fornecidos pelo usuário
                objCad.Nome = txtDeveloper.Text;
                objCad.Senha = txtPassword.Text;
                objCad.Email = txtEmail.Text;
                objCad.Twitter = txtTwitter.Text;
                objCad.Instagram = txtInstagram.Text;
                objCad.Discord = txtDiscord.Text;

                //cadastrar as informações
                objDAL.CadastrarDesenvolvedor(objCad);
                Limpar.ClearControl(this);
                txtDeveloper.Focus();
                MessageBox.Show($"Desenvolvedor(a) {objCad.Nome} cadastrado(a) com sucesso no RedSpace!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtDeveloper.Focus();
        }
    }
}
