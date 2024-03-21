using acPractica.Dal;
using acPractica.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acPractica.Bss
{
    public class ComputadoraBss
    {
        ComputadoraDal dal=new ComputadoraDal();
        
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
    }
}
