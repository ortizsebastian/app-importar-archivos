using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TransitoAgrupado
    {
        public int Estacion { get; set; }
        public int Via { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Placa { get; set; }
        public string FormaPago { get; set; }
        public byte Categoria { get; set; }
        public int Evento { get; set; }
    }
}
