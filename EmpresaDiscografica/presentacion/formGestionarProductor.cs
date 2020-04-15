using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaDiscografica.logica;

namespace EmpresaDiscografica
{
    public partial class formGestionarProductor : Form
    {
        clsProductorMusical productor = new clsProductorMusical();
        clsTrabaja trab = new clsTrabaja();
        clsValidar validacion = new clsValidar();
        public formGestionarProductor()
        {
            InitializeComponent();
        }

        private void btnGuardarProd_Click(object sender, EventArgs e)
        {
            int resultado;
            int tarjeta;
            string nombre, apellido, anioExp;
            char genero;
            tarjeta = (int.Parse(txtTarjetaPro.Text));
            if (tarjeta == 0)
            {
                MessageBox.Show("Información no registrada dado que el número de la Tarjeta Profesional no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nombre = txtNombreProd.Text;
            apellido = txtApellidoProd.Text;
            anioExp = cbxAnioExp.SelectedItem.ToString();
            genero = char.Parse(cbxGenero.SelectedItem.ToString());

            resultado = productor.insertarProductor(tarjeta, nombre, apellido, anioExp, genero);
            if (resultado == 1)
            {
                MessageBox.Show("Productor Musical Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Productor Musical No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            int tarjetaProd;
            tarjetaProd = int.Parse(txtTarjetaBuscar.Text);


            DataSet miDS = new DataSet();
            miDS = productor.consultarProdPorTarjeta(tarjetaProd);
            if (miDS.Tables[0].Rows.Count > 0)
            {
                txtActuTarjeta.Text = miDS.Tables[0].Rows[0]["prodNumTarjetaProf"].ToString();
                txtActuNombreProd.Text = miDS.Tables[0].Rows[0]["prodNombre"].ToString();
                txtActuApellido.Text = miDS.Tables[0].Rows[0]["prodApellido"].ToString();

                cbxActuAnioExp.Text = miDS.Tables[0].Rows[0]["prodAniosExp"].ToString();
                cbxActuGenero.Text = miDS.Tables[0].Rows[0]["prodGenero"].ToString();
            }
            else
            {
                MessageBox.Show("El Productor No está Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int resultado=0,tarjeta, tarjetaVieja;
            string nombre, apellido, aniExp; char  genero;


            tarjeta = int.Parse(txtActuTarjeta.Text);
            if (tarjeta == 0)
            {
                MessageBox.Show("Información no Actualizada dado que el número de la Tarjeta Profesional no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tarjetaVieja = int.Parse(txtTarjetaBuscar.Text);

            nombre = txtActuNombreProd.Text;
            apellido = txtActuApellido.Text;
            aniExp = cbxActuAnioExp.SelectedItem.ToString();
            genero = char.Parse(cbxActuGenero.SelectedItem.ToString());
            ds = trab.consultarVinculoProd(tarjetaVieja);

            if (tarjeta != tarjetaVieja)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("La tarjeta " + tarjetaVieja + " del productor musical no se puede actualizar porque está vinculada con algunas empresas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ds = productor.consultarProdPorTarjeta(tarjeta);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Productor musical No Actualizado porque ya existe un Productor registrado con esa tarjeta profesional.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    resultado = productor.actualizarProductor(tarjeta, nombre, apellido, aniExp, genero,tarjetaVieja);
                }
            }
            else
            {
                resultado = productor.actualizarProductor(tarjeta, nombre, apellido, aniExp, genero, tarjetaVieja);
  
                if (resultado == 1)
                {
                    MessageBox.Show("Productor musical Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("La tarjeta profesional " + tarjetaVieja + " del productor musical no se puede actualizar porque está relacionada con algunas empresas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if (resultado == 1)
            {
                MessageBox.Show("Productor musical Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Productor musical No Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnconsultarProd_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            dt = productor.consultarProductores();
            dgvDatosProductores.DataSource = dt;
            dgvDatosProductores.DataMember = "ResultadoDatos";
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            int tarjeta = int.Parse(txtTarjetaEliminar.Text);
            DataSet ds = new DataSet();

            int resultado;

            ds = trab.consultarVinculoProd(tarjeta);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("El Productor musical no se puede eliminar porque su tarjeta profesional está vinculada con algunas empresas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                resultado = productor.eliminarProductorPorTarjeta(tarjeta);
                if (resultado == 1)
                {
                    MessageBox.Show("Productor musical Eliminado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El productor musical no se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTarjetaPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtTarjetaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtActuTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtTarjetaEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void btnLimpiarRe_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlRegistroProd);
        }

        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlActualizarProd);
        }
    }
}
