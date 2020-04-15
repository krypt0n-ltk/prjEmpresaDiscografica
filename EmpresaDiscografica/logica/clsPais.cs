using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaDiscografica.datos;
using System.Data;

namespace EmpresaDiscografica.logica
{
    class clsPais
    {
        int resultado;
        clsDatos dt = new clsDatos();
        public int insertarPais(int cod, string nombre)
        {
            string consulta;
            consulta = "insert into Pais(paCod, panombre) values (" + cod + ",'" + nombre + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;

        }
        public DataSet consultarPaisPorCodigo(int codPa)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from pais where paCod=" + codPa;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
        public int actualizarPais(int codigoNuevo, string nombre, int codigoAntiguo)
        {
                string consulta;
                consulta = "update pais set paCod=" + codigoNuevo + ",paNombre='" + nombre + "' where paCod = " + codigoAntiguo;
                resultado = dt.ejecutarDML(consulta);
     
            return resultado;
        }
        public DataSet consultarPaises()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from pais";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public int eliminarPaisPorCodigo(int cod)
        {
            string consulta;
            consulta = "delete from Pais where paCod = " + cod;
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}
