using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public abstract class TableroEntities
    {
        public int NumeroCasillero { get; set; }
        public string? NombreProvincia { get; set; }
        public string TipoCasillero { get; set; }
        public double? PrecioCompra { get; set; }
        public double? PrecioAlquiler { get; set; }
        public double Monto { get; set; }
        public int? DniPropietario { get; set; }
    }
}