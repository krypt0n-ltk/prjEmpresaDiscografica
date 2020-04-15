using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaDiscografica.datos;
using System.Data;

namespace EmpresaDiscografica.logica
{
    class clsProductorMusical
    {
        clsDatos dt = new clsDatos();
        int resultado;
        public int insertarProductor(int tarjeta, string nombre, string apellido, string anioExp, char genero)
        {
            string consulta;
            consulta= "insert into productormusical(prodTjtaProf,prodNombre,prodApellido,prodAniosExp,prodGenero)values("+tarjeta+",'"+nombre+"','"+apellido+"','"+anioExp+"','" + genero + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;

        }

        public DataSet consultarProdPorTarjeta(int tarjetaProd)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from productorMusical where prodTjtaProf=" + tarjetaProd;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public int actualizarProductor(int tarjeta, string nombre, string apellido, string aniExp, char genero, int tarjetaVieja)
        {
            string consulta;

            consulta = "update productorMusical set prodTjtaProf=" + tarjeta + ",prodNombre='" + nombre + "',prodApellido='" + apellido + "',prodAniosExp='" + aniExp + "',prodGenero='" + genero + "' where prodTjtaProf = " + tarjetaVieja;

            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet consultarProductores()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from productormusical";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public int eliminarProductorPorTarjeta(int tarjeta)
        {
            string consulta;
            consulta = "delete from ProductorMusical where prodTjtaProf = " + tarjeta;
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}
