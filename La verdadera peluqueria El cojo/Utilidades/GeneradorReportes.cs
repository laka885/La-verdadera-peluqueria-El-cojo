using System;
using System.Collections.Generic;
using System.Text;
using PeluqueriaElCojo.Modelos;

namespace PeluqueriaElCojo.Utilidades
{
    public static class GeneradorReportes
    {
        
        public static string GenerarTicket<T>(List<T> items, string cliente, string barbero) where T : IFacturable
        {
          
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("      PELUQUERÍA EL COJO      ");
            sb.AppendLine("==============================");
            sb.AppendLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Cliente: " + cliente);
            sb.AppendLine("Barbero: " + barbero);
            sb.AppendLine("------------------------------");

            decimal total = 0;
            foreach (var item in items)
            {
                sb.AppendLine(item.GenerarLineaRecibo());
                total += item.CalcularPrecio();
            }

            decimal itbis = total * 0.18m;
            sb.AppendLine("------------------------------");
            sb.AppendLine(string.Format("Subtotal:     RD$ {0,10:N2}", total));
            sb.AppendLine(string.Format("ITBIS (18%):  RD$ {0,10:N2}", itbis));
            sb.AppendLine("==============================");
            sb.AppendLine(string.Format("TOTAL:        RD$ {0,10:N2}", total + itbis));

            return sb.ToString();
        }
    }
}