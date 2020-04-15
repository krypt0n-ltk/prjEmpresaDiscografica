using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;


namespace EmpresaDiscografica.datos
{
    class clsDatos
    {
        string cadenaConexion = "Data Source=localhost; User ID=userEmpDisc;Password=oracle";

        public int ejecutarDML(string consulta)
        {
            int filasAfectadas;
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            OracleCommand comando = new OracleCommand(consulta, miConexion);
            miConexion.Open();
            filasAfectadas = comando.ExecuteNonQuery();
            miConexion.Close();
            return filasAfectadas;

        }
        public DataSet ejecutarSELECT(string consulta)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);
            try
            {
                adaptador.Fill(ds, "ResultadoDatos");
            }
            catch(Exception e)
            {
                Console.WriteLine("Ha ocurrido un error inesperado con la conexión a la base de datos. Por favor consulte con el administrador.");
                Console.WriteLine(e.Message);
            }
                return ds;
                        
        }

    }
}
