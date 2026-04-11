using System;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    public class Empleado : IComparable<Empleado>
    {
        [Requerido]
        public string Nombre { get; set; }
        public decimal VentasAcumuladas { get; set; }

        // Ordenar por ventas de mayor a menor
        public int CompareTo(Empleado otro)
        {
            if (otro == null) return 1;
            return otro.VentasAcumuladas.CompareTo(this.VentasAcumuladas);
        }
    }
}