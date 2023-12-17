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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegar as informações do usuário
                string nome = txtUser.Text.Trim();
                string senha = txtPassword.Text.Trim();

                UsuarioDTO objDTO = new UsuarioDTO();
                UsuarioDAL objDAL = new UsuarioDAL();

                objDTO = objDAL.Autenticar(nome, senha);
                if (objDTO != null)
                {
                    Session.nomeUsuario = objDTO.Nome.Trim();
                    MDI_RedSpace MDI_Management = new MDI_RedSpace();
                    MDI_Management.Show();
                    this.Visible = false; //para não fechar || inativo
                }
                else
                {
                    MessageBox.Show($"Usuário {nome} não cadastrado!");
                    txtUser.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUser.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar.ClearControl(this);
            txtUser.Focus();
        }
    }
}
