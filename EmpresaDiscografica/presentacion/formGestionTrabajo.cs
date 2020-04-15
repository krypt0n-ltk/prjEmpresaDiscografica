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
    public partial class formGestionTrabajo : Form
    {
        clsProductorMusical productor = new clsProductorMusical();
        clsEmpresaDiscografica empresa = new clsEmpresaDiscografica();
        clsTrabaja trabajo = new clsTrabaja();
        clsValidar validacion = new clsValidar();
        public formGestionTrabajo()
        {
            InitializeComponent();
        }

        private void btnGuardarTra_Click(object sender, EventArgs e)
        {
            DataSet miDS = new DataSet();
            int resultado=0, tarj, cod;
            string fechFin, fechInicio;
            DateTime fechaInicio = dtpFechaInicio.Value;

            tarj = int.Parse(txtTarjetaProd.Text);
            cod = int.Parse(txtCodEmp.Text);
            if (tarj == 0)
            {
                MessageBox.Show("Información no registrada dado que el número de la tarjeta profesional no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(cod == 0)
            {
                MessageBox.Show("Información no registrada dado que el Codigo de la empresa no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fechInicio = fechaInicio.ToShortDateString();
            if (rbNo.Checked == true)
            {
                fechFin = null;
            }
            else{
                DateTime fechaFin = dtpFechaFin.Value;
                fechFin = fechaFin.ToShortDateString();
            }
          
            miDS = productor.consultarProdPorTarjeta(tarj);

            if (miDS.Tables[0].Rows.Count > 0)
            {
                miDS = empresa.consultarEmpresaPorCodigo(cod);
                if (miDS.Tables[0].Rows.Count > 0)
                {
                    miDS = trabajo.consultarVinculoProd(tarj);
                    if (miDS.Tables[0].Rows.Count > 0)
                    {
                        bool b = false;
                        for(int i = 0; i < miDS.Tables[0].Rows.Count; i++)
                        {
                            if (miDS.Tables[0].Rows[i]["traFechaFin"].ToString() == "")
                            {
                                b = true;
                            }                           
                        }
                        if (b == false)
                        {
                            resultado = trabajo.insertarVinculacion(cod, tarj, fechInicio, fechFin);
                        }
                        else
                        {
                            MessageBox.Show("El productor musical ingresado se encuentra vinculado actualmente con otra empresa.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (resultado == 1)
                            MessageBox.Show("Vinculo de Trabajo Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Vinculo de Trabajo No Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        resultado = trabajo.insertarVinculacion(cod, tarj, fechInicio, fechFin);
                        if (resultado == 1)
                            MessageBox.Show("Vinculo de Trabajo Registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Vinculo de No Trabajo Registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("La Empresa Discográfica ingresada no se encuentra registrada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El productor musical ingresado no se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            lbFechaFin.Show();
            dtpFechaFin.Show();
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            lbFechaFin.Hide();
            dtpFechaFin.Hide();
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = trabajo.consultaUno();
            dgvConsulta1.DataSource = ds;
            dgvConsulta1.DataMember = "ResultadoDatos";
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string fecha;
            fecha = dtpFechCon2.Value.ToShortDateString();

            ds = trabajo.consultaDos(fecha);
            dgvConsulta1.DataSource = ds;
            dgvConsulta1.DataMember = "ResultadoDatos";

        }

        private void txtTarjetaProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtCodEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void btnLimpiarReg_Click(object sender, EventArgs e)
        {
            validacion.limpiar(pnlRegistroTra);
        }
    }
}
