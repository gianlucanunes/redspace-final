using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSpaceDesktop.DSKT.Utilities
{
    public static class Limpar //o public pode ser gerado automaticamente quando a classe é criada em uma pasta (entende-se que será usada ou acessada)
    {
        public static void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls) //contador c para a coleção que são todos os controles
            {
                if (c is TextBox) //se o componente for Text
                {
                    ((TextBox)c).Text = string.Empty; //casting forçando a converção
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = string.Empty; //limpar a mascara de data
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = -1;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                ClearControl(c);
            }
        }
    }
}
