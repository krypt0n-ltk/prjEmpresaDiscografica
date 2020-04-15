using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaDiscografica.datos;
using System.Data;

namespace EmpresaDiscografica.logica
{
    class clsEmpresaDiscografica
    {
        clsDatos dt = new clsDatos();
        int resultado;

        public int insertarEmpresa (int empCodigo, int paCodigo, string empNombre, int empAnioFund, string empTipo)
        {
            string consulta;
            consulta = "insert into  EmpresaDiscografica(empCod,paCod,empNombre,empAnioFund,empTipo) values(" + empCodigo + "," + paCodigo + ",'" + empNombre + "'," + empAnioFund + ",'" + empTipo + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;

        }

        public DataSet  consultarEmpresaPorCodigo(int codigo)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from empresaDiscografica where empCod=" + codigo;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet consultarEmpresaPorPais(int codigoPais)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from empresaDiscografica where paCod=" + codigoPais;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet consultarEmpresas()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from empresaDiscografica";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
        public int actualizarEmpresa(int empCodigo, int paCodigo,string  empNombre, int empAnioFund, string empTipo, int codigoViejo)
        {
            string consulta;
            
            consulta = "update EmpresaDiscografica set empCod=" + empCodigo + ",paCod=" + paCodigo + ",empNombre='" + empNombre + "',empAnioFund=" + empAnioFund + ",empTipo='" + empTipo + "' where empCod = "+ codigoViejo;
               
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultaPais(int codigo)
        {
             DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from empresaDiscografica where paCod=" +codigo ;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;

        }

        public int eliminarEmpresaPorCodigo(int codigo)
        {
            string consulta;
            consulta = "delete from EmpresaDiscografica where empCod = " + codigo;
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

       

    }
}
