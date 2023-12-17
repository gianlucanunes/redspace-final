using RedSpaceDesktop.DAL;
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
    public partial class MDI_RedSpace : Form
    {
        public MDI_RedSpace()
        {
            InitializeComponent();
            lblSession.Text = $"Seja bem-vindo(a), {Session.nomeUsuario.ToUpper()}! Sua sessão no sistema do RedSpace foi feita em: {DateTime.Now}";
        }

        //SAIR -----------------------------------------------------------------------------------------------------------------------
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Usuário {Session.nomeUsuario.ToUpper()}, sua sessão será finalizada.", "Atenção", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Usuário {Session.nomeUsuario.ToUpper()}, sua sessão será finalizada.", "Atenção", MessageBoxButtons.OK);
            Application.Exit();
        }

        //CALCULADORA -----------------------------------------------------------------------------------------------------------------------
        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        //NOTEPAD -----------------------------------------------------------------------------------------------------------------------
        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void Notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        //WORD -----------------------------------------------------------------------------------------------------------------------
        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        //EXCEL -----------------------------------------------------------------------------------------------------------------------
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        //POWERPOINT -----------------------------------------------------------------------------------------------------------------------
        private void powerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt");
        }

        private void PowerPoint_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt");
        }

        //CADASTRAR (CREATE Desenvolvedor) -----------------------------------------------------------------------------------------------------------------------

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            FrmCadastrar obj = new FrmCadastrar();
            obj.ShowDialog();
        }

        //EDITAR (UPDATE Desenvolvedor) -----------------------------------------------------------------------------------------------------------------------

        private void updateAtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            FrmEditar obj = new FrmEditar();
            obj.ShowDialog();
        }

        //EXCLUIR (DELETE Desenvolvedor) -----------------------------------------------------------------------------------------------------------------------

        private void deleteExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcluir obj = new FrmExcluir();
            obj.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            FrmExcluir obj = new FrmExcluir();
            obj.ShowDialog();
        }

        //LISTAR (READ Desenvolvedor) -----------------------------------------------------------------------------------------------------------------------

        private void Read_Click(object sender, EventArgs e)
        {
            FrmListar obj = new FrmListar();
            obj.ShowDialog();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListar obj = new FrmListar();
            obj.ShowDialog();
        }

        //PUBLICAR (CREATE Jogo) -----------------------------------------------------------------------------------------------------------------------
        private void publicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPublicar obj = new FrmPublicar();
            obj.ShowDialog();
        }

        private void Publicar_Click(object sender, EventArgs e)
        {
            FrmPublicar obj = new FrmPublicar();
            obj.ShowDialog();
        }

        //CATALOGAR (READ Jogo) -----------------------------------------------------------------------------------------------------------------------
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatalogar obj = new FrmCatalogar();
            obj.ShowDialog();
        }

        private void Catalogar_Click(object sender, EventArgs e)
        {
            FrmCatalogar obj = new FrmCatalogar();
            obj.ShowDialog();
        }

        //ATUALIZAR (UPDATE Jogo) -----------------------------------------------------------------------------------------------------------------------
        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtualizar obj = new FrmAtualizar();
            obj.ShowDialog();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            FrmAtualizar obj = new FrmAtualizar();
            obj.ShowDialog();
        }

        //REMOVER (DELETE Jogo) -----------------------------------------------------------------------------------------------------------------------
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemover obj = new FrmRemover();
            obj.ShowDialog();
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            FrmRemover obj = new FrmRemover();
            obj.ShowDialog();
        }

        //ADICIONAR (CREATE Galeria) -----------------------------------------------------------------------------------------------------------------------
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdicionar obj = new FrmAdicionar();
            obj.ShowDialog();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionar obj = new FrmAdicionar();
            obj.ShowDialog();
        }

        //MODIFICAR (UPDATE Galeria) -----------------------------------------------------------------------------------------------------------------------
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar obj = new FrmModificar();
            obj.ShowDialog();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            FrmModificar obj = new FrmModificar();
            obj.ShowDialog();
        }
    }
}
