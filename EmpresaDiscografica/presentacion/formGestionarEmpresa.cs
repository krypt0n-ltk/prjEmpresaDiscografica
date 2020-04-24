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
    public partial class formGestionarEmpresa : Form
    {
        clsEmpresaDiscografica emp = new clsEmpresaDiscografica();
        clsProductorMusical prod = new clsProductorMusical();
        clsPais pais = new clsPais();
        clsTrabaja trab = new clsTrabaja();
        clsValidar validacion = new clsValidar();



        public formGestionarEmpresa()
        {
            InitializeComponent();
        }


        private void btnGuardarEmp_Click(object sender, EventArgs e)
        {
            int resultado=0;
            int empCodigo,paCodigo, empAnioFund;
            DataSet dsCodPa = new DataSet();
            paCodigo = int.Parse(txtRegCodPa.Text);
            string empNombre, empTipo="";

            empCodigo = int.Parse(txtCodigoEmp.Text);
            if (empCodigo == 0)
            {
                MessageBox.Show("Información no registrada dado que el código de la Empresa no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dsCodPa = pais.consultarPaisPorCodigo(paCodigo);
            if (dsCodPa.Tables[0].Rows.Count > 0)
            {
                empNombre = txtNombreEmp.Text;
                empAnioFund = dtpAnioFund.Value.Year;
                if (rbSubsidiaria.Checked == true)
                    empTipo = "subsidiaria";
                else
                    empTipo = "casa matriz";
                 resultado = emp.insertarEmpresa(empCodigo, paCodigo, empNombre, empAnioFund, empTipo);
                if (resultado == 1)
                    MessageBox.Show("Empresa Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Empresa No Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El codigo del país no existe.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            int cod;
            cod = int.Parse(txtBuscarCodigo.Text);
            

            DataSet miDS = new DataSet();
            miDS = emp.consultarEmpresaPorCodigo(cod);
            if (miDS.Tables[0].Rows.Count > 0)
            {
                txtActuCodigoEmp.Text = miDS.Tables[0].Rows[0]["empCod"].ToString();
                txtActuCodPa.Text = miDS.Tables[0].Rows[0]["paCod"].ToString();
                txtActuNomEmp.Text = miDS.Tables[0].Rows[0]["empNombre"].ToString();

                txtActuAnioEmp.Text = miDS.Tables[0].Rows[0]["empAnioFund"].ToString();

                if (miDS.Tables[0].Rows[0]["empTipo"].ToString() == "subsidiaria")
                {
                    rbActuSubsi.Checked = true;
                    rbActuCasa.Checked = false;
                }
                else
                {
                    rbActuSubsi.Checked = false;
                    rbActuCasa.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("La Empresa No está Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int resultado=0;
            DataSet dsCodPa = new DataSet();
            DataSet dsCodEmp = new DataSet();
            int empCodigo, paCodigo, empAnioFund, empCodigoViejo;
          
            string empNombre, empTipo = "";

            empCodigo = int.Parse(txtActuCodigoEmp.Text);
            if (empCodigo == 0)
            {
                MessageBox.Show("Información no Actualizada dado que el código de la Empresa no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            empCodigoViejo = int.Parse(txtBuscarCodigo.Text);
            paCodigo = int.Parse(txtActuCodPa.Text);

            empNombre = txtActuNomEmp.Text;
            empAnioFund = int.Parse(txtActuAnioEmp.Text);

            if (rbActuSubsi.Checked == true)
                empTipo = "subsidiaria";
            else
                empTipo = "casa matriz";

            dsCodEmp = emp.consultarEmpresaPorCodigo(empCodigo);
            dsCodPa = emp.consultaPais(paCodigo);

            if (empCodigo != empCodigoViejo)
            {
                if (dsCodEmp.Tables[0].Rows.Count > 0)
                {
                    if ((dsCodEmp.Tables[0].Rows[0]["empCod"].ToString()) == (txtBuscarCodigo.Text))
                    {
                        if (dsCodPa.Tables[0].Rows.Count > 0)
                        {
                            resultado = emp.actualizarEmpresa(empCodigo, paCodigo, empNombre, empAnioFund, empTipo, empCodigoViejo);

                            if (resultado == 1)
                                MessageBox.Show("Empresa Actualizada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Empresa No Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Empresa No actualizada porque el codigo del Pais  no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Empresa No actualizada porque el codigo de la Empresa ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = emp.actualizarEmpresa(empCodigo, paCodigo, empNombre, empAnioFund, empTipo, empCodigoViejo);

                    if (resultado == 1)
                        MessageBox.Show("Empresa Actualizada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Empresa No Actualizada!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                if (dsCodPa.Tables[0].Rows.Count > 0)
                {
                    resultado = emp.actualizarEmpresa(empCodigo, paCodigo, empNombre, empAnioFund, empTipo, empCodigoViejo);

                    if (resultado == 1)
                        MessageBox.Show("Empresa Actualizada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Empresa No Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Empresa No actualizada porque el codigo del Pais  no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                

            }

        }

        private void btnConsultarEmp_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            dt = emp.consultarEmpresas();
            dgvDatosEmpresas.DataSource = dt;
            dgvDatosEmpresas.DataMember = "ResultadoDatos";
        }

        private void btnEliminarEmp_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCodEmpEliminar.Text);
            DataSet ds = new DataSet();

            int resultado;

            ds = trab.consultarVinculoEmp(cod);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("La empresa no se puede eliminar porque su codigo está vinculado con algunos productores musicales.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultado = emp.eliminarEmpresaPorCodigo(cod);
                if (resultado == 1)
                {
                    MessageBox.Show("Empresa discográfica Eliminada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Empresa discográfica no está registrada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodigoEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtActuCodigoEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtActuCodPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCodEmpEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtRegCodPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void btnLimpiarRe_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlRegistroEmp);
        }

        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlActualizarEmp);
        }
    }
}
