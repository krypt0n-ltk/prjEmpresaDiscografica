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
    public partial class formGestionarPais : Form
    {

        clsPais pa = new clsPais();
        clsEmpresaDiscografica emp = new clsEmpresaDiscografica();
        clsValidar validacion = new clsValidar();

        public formGestionarPais()
        {
            InitializeComponent();
        }

        private void btnGuardarPais_Click(object sender, EventArgs e)
        {
            int resultado=0;
            int cod; string nombre;
            cod = int.Parse(txtCodigoPais.Text);
            nombre = txtNombrePais.Text;
            if (cod == 0)
            {
                MessageBox.Show("Información no registrada dado que el Codigo del País no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet miDS = new DataSet();
            miDS = pa.consultarPaisPorCodigo(cod);
            if (miDS.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("El codigo del país ya existe.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                resultado = pa.insertarPais(cod, nombre);
            }
            if (resultado == 1)
            {
                MessageBox.Show("Pais Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscarPais_Click(object sender, EventArgs e)
        {
            int codPa;
            codPa = int.Parse(txtCodBuscarPais.Text);


            DataSet miDS = new DataSet();
            miDS = pa.consultarPaisPorCodigo(codPa);
            if (miDS.Tables[0].Rows.Count > 0)
            {
                txtActuCodPais.Text = miDS.Tables[0].Rows[0]["paCodigo"].ToString();
                txtActuNomPais.Text = miDS.Tables[0].Rows[0]["paNombre"].ToString();
              
            }
            else
            {
                MessageBox.Show("El Pais No está Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnActualizarPais_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            int resultado = 0, codigo, codigoViejo;
            string nombre;

            codigo = int.Parse(txtActuCodPais.Text);
            if (codigo == 0)
            {
                MessageBox.Show("Información no Actualizada dado que el Codigo del País no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nombre = txtActuNomPais.Text;
            codigoViejo = int.Parse(txtCodBuscarPais.Text);

            ds = emp.consultarEmpresaPorPais(codigoViejo);
            

            if (codigo != codigoViejo)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("El codigo " + codigoViejo + " del pais no se puede actualizar porque está relacionado con algunas empresas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
                ds = pa.consultarPaisPorCodigo(codigo);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Pais No Actualizado porque ya existe un pais con ese código.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    resultado = pa.actualizarPais(codigo, nombre, codigoViejo);
                }
            }
            else
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    resultado = pa.actualizarPais(codigo, nombre, codigoViejo);
                    
                }
                if(resultado == 1)
                {
                    MessageBox.Show("Pais Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("El codigo " + codigoViejo + " del pais no se puede actualizar porque está relacionado con algunas empresas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

            }

            if (resultado == 1)
            {
                MessageBox.Show("Pais Actualizado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais No Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConsultarPais_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            dt = pa.consultarPaises();
            dgvDatosPaises.DataSource = dt;
            dgvDatosPaises.DataMember = "ResultadoDatos";
        }

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCodPaisEliminar.Text);
            DataSet ds = new DataSet();

            int resultado;

            ds = emp.consultarEmpresaPorPais(cod);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("El pais no se puede eliminar porque su código está relacionado con algunas empresas.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                resultado = pa.eliminarPaisPorCodigo(cod);
                if (resultado == 1)
                {
                    MessageBox.Show("Pais Eliminado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pais No Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void txtCodigoPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCodBuscarPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtActuCodPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCodPaisEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void btnLimpiarReg_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlRegistroPais);
        }

        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlActualizarPais);
        }
    }
    
}
