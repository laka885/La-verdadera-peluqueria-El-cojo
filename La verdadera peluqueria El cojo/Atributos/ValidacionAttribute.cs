using System;

namespace PeluqueriaElCojo.Atributos
{
    // Clase base para todos los atributos de validación
    public abstract class ValidacionAttribute : Attribute
    {
        public abstract bool EsValido(object valor);
        public string MensajeError { get; set; }
    }

    // Atributo para campos obligatorios
    [AttributeUsage(AttributeTargets.Property)]
    public class RequeridoAttribute : ValidacionAttribute
    {
        public override bool EsValido(object valor) => valor != null && !string.IsNullOrEmpty(valor.ToString());
    }

    // Atributo para rangos numéricos
    [AttributeUsage(AttributeTargets.Property)]
    public class RangoAttribute : ValidacionAttribute
    {
        private double _min, _max;
        public RangoAttribute(double min, double max) { _min = min; _max = max; }
        public override bool EsValido(object valor) => double.TryParse(valor.ToString(), out var n) && n >= _min && n <= _max;
    }
}