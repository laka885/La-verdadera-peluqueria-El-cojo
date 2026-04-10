namespace PeluqueriaElCojo.Modelos
{
    public class Degradado : Servicio
    {
        public int Nivel { get; set; } // 1, 2 o 3
        public override decimal CalcularPrecio() => PrecioBase + (Nivel * 50);
    }
}