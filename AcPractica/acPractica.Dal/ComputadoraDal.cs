using acPractica.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace acPractica.Dal
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal() 
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabala");
            return lista;
        }

        public void InsertarComputadoraDal(Computadora computadora)
        {
            string consulta = "insert into computadora values ('" + computadora.Nombre + "' ," +
                                                           "'" + computadora.Descripcion + "'," +
                                                           "" + computadora.Precio + "," +
                                                           "'" + computadora.FechaFabricacion+ "')";
            conexion.Ejecutar(consulta);
        }

    }
}
