using System;
using System.Collections.Generic;
using System.Reflection;
using PeluqueriaElCojo.Atributos;

namespace PeluqueriaElCojo.Utilidades
{
    public static class Validador
    {
        public static List<string> Validar(object obj)
        {
            var errores = new List<string>();
            if (obj == null) return errores;

            // Reflection: obtenemos las propiedades del objeto en tiempo de ejecución
            PropertyInfo[] propiedades = obj.GetType().GetProperties();

            foreach (var prop in propiedades)
            {
                // Buscamos si la propiedad tiene atributos de validación
                object[] atributos = prop.GetCustomAttributes(typeof(ValidacionAttribute), true);

                foreach (object attr in atributos)
                {
                    ValidacionAttribute validacion = attr as ValidacionAttribute;
                    if (validacion != null)
                    {
                        object valor = prop.GetValue(obj, null);
                        if (!validacion.EsValido(valor))
                        {
                            errores.Add(validacion.MensajeError ?? "Dato inválido en " + prop.Name);
                        }
                    }
                }
            }
            return errores;
        }
    }
}