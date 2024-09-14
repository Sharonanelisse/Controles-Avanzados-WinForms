using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesAvanzados.Clases
{
    internal class Venta
    {
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Departamento { get; set; }    
        public double Ventas { get; set; }  

        public Venta(int anio, int mes, string departamento, double ventas)
        {
            Anio = anio;
            Mes = mes;
            Departamento = departamento;
            Ventas = ventas;
        }
    }
}
