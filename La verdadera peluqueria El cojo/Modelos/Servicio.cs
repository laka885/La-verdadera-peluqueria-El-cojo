using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Modelos
{
    public abstract class Servicio : IFacturable
    {
        [Requerido(MensajeError = "El nombre del servicio es obligatorio")]
        public string Nombre { get; set; }

        [Rango(0, 5000, MensajeError = "Precio fuera de rango")]
        public decimal PrecioBase { get; set; }

        // Polimorfismo: las clases hijas podrán cambiar este comportamiento
        public virtual decimal CalcularPrecio() => PrecioBase;

        public string GenerarLineaRecibo()
        {
            return string.Format("{0,-20} RD$ {1,10:N2}", Nombre, CalcularPrecio());
        }
    }
}