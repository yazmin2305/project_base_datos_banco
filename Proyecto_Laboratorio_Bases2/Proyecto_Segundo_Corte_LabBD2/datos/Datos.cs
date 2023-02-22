using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;


namespace Proyecto_Segundo_Corte_LabBD2.datos
{
    class Datos
    {
        //establecer la cadena de conexion 
        OracleConnection miConexion = new OracleConnection(@"Data Source = localhost; User ID = yazparcial; Password= colombia");
        public int RegistrarBancoBD(int banNit, string banNombre, string banFechaCreacion)
        {
            int resultado = 0;

            try
            {
                miConexion.Open();
                OracleCommand ora_cmd = new OracleCommand("yazparcial.prcRegistrarBanco", miConexion);
                ora_cmd.Parameters.Add("v_nit", OracleDbType.Decimal, banNit, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_nomBan", OracleDbType.Varchar2, 256).Value = banNombre;
                ora_cmd.Parameters.Add("v_fechaBan", OracleDbType.Varchar2, 256).Value = banFechaCreacion;

                ora_cmd.CommandType = CommandType.StoredProcedure;

                resultado = ora_cmd.ExecuteNonQuery();

            }
            finally
            {
                if (miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }
            return 1;

        }
        public int RegistrarSucursalBD(int codigo, string nombre, string ubicacion, int numEmp, int antiguedad, int BanNit)
        {
            int resultado = 0;
            try
            {
                miConexion.Open();
                OracleCommand ora_cmd = new OracleCommand("yazparcial.prcRegistrarSucursal", miConexion);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("v_codigo", OracleDbType.Decimal, codigo, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_nomSuc", OracleDbType.Varchar2, 256).Value = nombre;
                ora_cmd.Parameters.Add("v_ubicacion", OracleDbType.Varchar2, 256).Value = ubicacion;
                ora_cmd.Parameters.Add("v_numEmp", OracleDbType.Decimal, numEmp, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_aniosSuc", OracleDbType.Decimal, antiguedad, ParameterDirection.Input);
                ora_cmd.Parameters.Add("v_nit", OracleDbType.Decimal, BanNit, ParameterDirection.Input);

                resultado = ora_cmd.ExecuteNonQuery();
            }
            finally
            {
                if (miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }
            return 1;
        }

        public DataSet ObtenerSucursales(string nombre, string ubicacion)
        {
            try
            {
                miConexion.Open();
                OracleCommand ora_cmd = new OracleCommand("yazparcial.prcConsultarSucursales", miConexion);
                ora_cmd.Parameters.Add("v_nomBanc", OracleDbType.Varchar2, 256).Value = nombre;
                ora_cmd.Parameters.Add("v_ubicacion", OracleDbType.Varchar2, 256).Value = ubicacion;
                ora_cmd.Parameters.Add("curInfoSucursal", OracleDbType.RefCursor, ParameterDirection.Output);                
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sucursales");
                return ds;
            }
            finally
            {
                if (miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }
        }
    }
}
