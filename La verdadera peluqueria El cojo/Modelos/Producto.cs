using System;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    public class Producto : IEquatable<Producto>, ICloneable
    {
        [Requerido(MensajeError = "El código es obligatorio")]
        public string Codigo { get; set; }

        [Requerido]
        public string Nombre { get; set; }

        [Rango(1, 10000)]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        // Requisito: Detectar duplicados por código
        public bool Equals(Producto otro)
        {
            if (otro == null) return false;
            return this.Codigo == otro.Codigo;
        }

        // Requisito: Clonar productos
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj) => Equals(obj as Producto);
        public override int GetHashCode() => (Codigo != null ? Codigo.GetHashCode() : 0);
    }
}