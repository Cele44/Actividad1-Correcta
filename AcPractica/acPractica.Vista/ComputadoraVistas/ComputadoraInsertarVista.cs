using acPractica.Bss;
using acPractica.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acPractica.Vista.ComputadoraVistas
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
        ComputadoraBss bss =new ComputadoraBss();
        private void button1_Click(object sender, EventArgs e)
        {
           Computadora c = new Computadora();
            c.Nombre = textBox1.Text;
            c.Descripcion = textBox2.Text;
            c.Precio=Convert.ToDecimal(textBox3.Text);
            c.FechaFabricacion =dateTimePicker1.Value;

            bss.InsertarComputadoraBss(c);
            MessageBox.Show("Se guardo corecctamente la computadora");
        }
    }
}
