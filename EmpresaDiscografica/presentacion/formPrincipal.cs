using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaDiscografica.presentacion;


namespace EmpresaDiscografica
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnEmpDiscografica_Click(object sender, EventArgs e)
        {
            Form formulario = new formGestionarEmpresa();
            formulario.Show();
        }

        private void btnProdMusical_Click(object sender, EventArgs e)
        {
            Form formulario = new formGestionarProductor();
            formulario.Show();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            Form formulario = new formGestionarPais();
            formulario.Show();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            Form formulario = new formGestionTrabajo();
            formulario.Show();
        }

        private void btnConsultaVivo_Click(object sender, EventArgs e)
        {
            Form formulario = new formConsultaEnVivo();
            formulario.Show();
        }
    }
}
