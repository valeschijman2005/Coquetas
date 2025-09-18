using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public class MovimientoEntities
    {
        public List<CasilleroEntities> MovimientoCasillero { get; set; } = new List<CasilleroEntities>();
        public List<double> PagosAlquiler { get; set; } = new List<double>();
    }
}
