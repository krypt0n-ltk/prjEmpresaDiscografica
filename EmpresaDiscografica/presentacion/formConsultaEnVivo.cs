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
    public partial class formConsultaEnVivo : Form
    {
        clsTrabaja trabajo = new clsTrabaja();
        public formConsultaEnVivo()
        {
            InitializeComponent();
        }

        private void btnConsultaVivo_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = trabajo.consultaEnVivo();
            dgvConsultaVivo.DataSource = ds;
            dgvConsultaVivo.DataMember = "ResultadoDatos";

        }
    }
}
