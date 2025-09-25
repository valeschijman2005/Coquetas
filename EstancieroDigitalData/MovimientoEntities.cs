using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public class MovimientoEntities
    {
        public List<TableroEntities> MovimientoCasillero { get; set; } = new List<TableroEntities>();
        public List<double> PagosAlquiler { get; set; } = new List<double>();
    }
}