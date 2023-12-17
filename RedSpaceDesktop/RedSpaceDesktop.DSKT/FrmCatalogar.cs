using DGVPrinterHelper;
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
    public partial class FrmCatalogar : Form
    {
        public FrmCatalogar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            JogoDAL objLista = new JogoDAL();
            dgv1.DataSource = objLista.ListarJogos();

            //formatação básica de dgv
            DataGridViewCellStyle cabecalho = new DataGridViewCellStyle();

            cabecalho.BackColor = SystemColors.ButtonFace;
            dgv1.ColumnHeadersDefaultCellStyle = cabecalho;
            dgv1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lbl1.Text;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(dgv1);
        }
    }
}
