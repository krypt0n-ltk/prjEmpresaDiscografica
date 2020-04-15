using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaDiscografica.logica
{
    class clsValidar
    {
        public  void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
               // MessageBox.Show("Solo Letras");
            }
        }

        public  void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                //MessageBox.Show("Solo Numeros");
            }
        }

        public void NumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                //MessageBox.Show("Solo numeros o numeros con punto decimal");
            }
        }
        public void limpiar(Panel p)
        {
            foreach (Control text in p.Controls)
            {
                if (text is TextBox)
                {
                    ((TextBox)text).Clear();

                }
                else if (text is ComboBox)
                {
                    ((ComboBox)text).SelectedIndex = 0;
                }
            }
        }

    }
}
