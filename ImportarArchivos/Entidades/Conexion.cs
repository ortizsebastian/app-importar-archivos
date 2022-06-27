using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Conexion
    {
        private readonly SqlCommand oCmd;

        private readonly SqlConnection oConn;
        public SqlDataReader oDr { get; set; }
        public Conexion()
        {
            oConn = new SqlConnection("Initial Catalog=PeajeUchumayo_FE; Data Source=SRV-UCHUMAYO; Persist Security Info=False; User ID=replsa; Password=Repls@01;");
            //oConn = new SqlConnection("Initial Catalog=PANAVIAL_Consolidado_E; Data Source=SRVBIROME\\SQLDESA; Persist Security Info=False; User ID=sa; Password=Admin01;");
            oCmd = new SqlCommand();
        }

        public void setConsulta(string consulta)
        {
            oCmd.CommandType = System.Data.CommandType.Text;
            oCmd.CommandText = consulta;
        }

        public void Lectura()
        {
            oCmd.Connection = oConn;
            try
            {
                oConn.Open();
                oDr = oCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setParametro(string nombre, object valor)
        {
            oCmd.Parameters.AddWithValue(nombre, valor);
        }

        public void Cerrar()
        {
            if (oDr != null) oDr.Close();
            oConn.Close();
        }
    }
}
