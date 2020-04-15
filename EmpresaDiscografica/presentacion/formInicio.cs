using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaDiscografica.presentacion
{
    public partial class formInicio : Form
    {
        // variable que permite conocer cual formulario está activo
        private Form formActivo = null;

        public formInicio()
        {
            InitializeComponent();
            inicializarDiseño();
        }

        /// <summary>
        /// Inicializa el diseño del form ocultando los submenus.
        /// </summary>
        public void inicializarDiseño()
        {
            pnlEmpSubmenu.Visible = false;
            pnlProdSubmenu.Visible = false;
            pnlPaisSubmenu.Visible = false;
        }

        /// <summary>
        /// Oculta todos los submenus que se encuentren visibles.
        /// </summary>
        public void ocultarSubmenus()
        {
            if (pnlEmpSubmenu.Visible == true)
            {
                pnlEmpSubmenu.Visible = false;
            }
            if (pnlProdSubmenu.Visible == true)
            {
                pnlProdSubmenu.Visible = false;
            }
            if (pnlPaisSubmenu.Visible == true)
            {
                pnlPaisSubmenu.Visible = false;
            }
        }

        /// <summary>
        /// Activa o desactiva la visibilidad del panel "prmSubmenu" dependiendo del estado en que se encuentre. En el caso de que esté desactivada, se oculta cualquier otro submenú que se enncuentre visible.
        /// </summary>
        /// <param name="prmSubmenu"> Panel a ser ocultado o mostrado.</param>
        public void mostrarSubmenu(Panel prmSubmenu)
        {
            if (prmSubmenu.Visible == false)
            {
                ocultarSubmenus();
                prmSubmenu.Visible = true;
            }
            else
            {
                prmSubmenu.Visible = false;
            }
                
        }

        #region eventos
        private void btnEmpDisc_Click(object sender, EventArgs e)
        {
            //mostrarSubmenu(pnlEmpSubmenu);
            abrirFormulario(new formGestionarEmpresa());
        }

        private void btnProductor_Click(object sender, EventArgs e)
        {
            //mostrarSubmenu(pnlProdSubmenu);
            abrirFormulario(new formGestionarProductor());
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            //mostrarSubmenu(pnlPaisSubmenu);
            abrirFormulario(new formGestionarPais());
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formGestionTrabajo());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            abrirFormulario(new formConsultaEnVivo());
        }
        #endregion


        /// <summary>
        /// Configura y muestra el form "prmFormulario", cerrando el que se encuentre activo en el momento.
        /// </summary>
        /// <param name="prmFormulario">Formulario a mostrar</param>
        private void abrirFormulario(Form prmFormulario)
        {
            if (formActivo != null)
                formActivo.Close();

            if (prmFormulario != null)
            {
                formActivo = prmFormulario;
                prmFormulario.TopLevel = false; // para manejar el form como un simple control y no como una ventana
                prmFormulario.FormBorderStyle = FormBorderStyle.None;
                prmFormulario.Dock = DockStyle.Fill;

                pnlContenedorForms.Controls.Add(prmFormulario);
                pnlContenedorForms.Tag = prmFormulario; // para relacionar los dos elementos

                prmFormulario.BringToFront(); // en caso de tener un logo

                prmFormulario.Show();
            }
        }

        
    }
}
