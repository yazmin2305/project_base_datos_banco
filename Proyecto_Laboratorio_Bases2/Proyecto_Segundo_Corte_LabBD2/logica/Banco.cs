using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Segundo_Corte_LabBD2.datos;

namespace Proyecto_Segundo_Corte_LabBD2.logica
{
    class Banco
    {
        Datos dt = new Datos();
        public int RegistrarBanco(int banNit, string banNombre, string banFechaCreacion)
        {
            int resultado;
            //invocar el metodo en la capa de datso que permite hacer la consulta del banco a travez de un PA
            //string respuesta = "";
            //respuesta = dt.RegistrarBancoBD(banNit, banNombre, banFechaCreacion);
            //return respuesta;
            resultado = dt.RegistrarBancoBD(banNit, banNombre, banFechaCreacion);
            return resultado;
        }
    }
}
