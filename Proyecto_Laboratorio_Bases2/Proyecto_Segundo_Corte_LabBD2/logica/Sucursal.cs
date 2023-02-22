using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Segundo_Corte_LabBD2.datos;
using System.Data;

namespace Proyecto_Segundo_Corte_LabBD2.logica
{
    class Sucursal
    {
        Datos dt = new Datos();

        public int RegistrarSucursal(int codigo, string nombre, string ubicacion, int numEmp, int antiguedad, int BanNit)
        {
            int resultado;
            resultado = dt.RegistrarSucursalBD(codigo, nombre, ubicacion, numEmp, antiguedad, BanNit);
            return resultado;
        }

        public DataSet ConsultarSucursales(string nombre, string ubicacion)
        {
            DataSet conjuntoSucursales = new DataSet();
            conjuntoSucursales = dt.ObtenerSucursales(nombre, ubicacion);
            return conjuntoSucursales;
        }

    }
}
