using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaDiscografica.datos;
using System.Data;

namespace EmpresaDiscografica.logica
{
    class clsTrabaja
    {
        clsDatos dt = new clsDatos();
        int resultado;

        public DataSet consultarVinculoProd(int tarjeta)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from Trabaja where prodTjtaProf=" + tarjeta;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet consultarVinculoEmp(int codigo)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select * from Trabaja where empCod=" + codigo;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }
        public int insertarVinculacion(int cod, int tarj, string fechInicio,string fechFin)
        {
            string consulta;
            consulta = "insert into  trabaja(empCod,prodtjtaprof,traFechaInicio,traFechaFin) values(" + cod + "," + tarj + ",'" + fechInicio + "','" + fechFin + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;

        }
        public DataSet consultaUno()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "select emp.empcod,emp.pacod,emp.empnombre,emp.empaniofund,emp.emptipo,p.prodtjtaprof,p.prodnombre,p.prodapellido,p.prodaniosexp,p.prodgenero,t.trafechainicio,t.trafechafin " +
            "from empresaDiscografica emp " +
            "inner join trabaja t " +
            "on emp.empcod = t.empcod " +
            "inner join productorMusical p " +
            "on p.prodtjtaprof = t.prodtjtaprof";

            miDS = dt.ejecutarSELECT(consulta);
            return miDS;

        }
        public DataSet consultaDos(string fecha)
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta =
                "select emp.empcod,emp.empnombre,p.panombre,pm.prodtjtaprof,pm.prodnombre,pm.prodapellido,t.trafechafin " +
                "from trabaja t inner join empresaDiscografica emp " +
                "on emp.empcod = t.empcod " +
                "inner join pais p " +
                "on p.pacod = emp.pacod " +
                "inner join productorMusical pm " +
                "on pm.prodtjtaprof = t.prodtjtaprof " +
                "where t.trafechainicio = '" + fecha + "'" ;
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet consultaEnVivo()
        {
            DataSet miDS = new DataSet();
            string consulta;
            consulta = "";
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }


    }
}
