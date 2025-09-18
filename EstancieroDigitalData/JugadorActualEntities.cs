using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public class JugadorActualEntities
    {
        public int DNI { get; set; }
        public CasilleroEntities PosicionActual { get; set; }
        public double DineroDisponible { get; set; }
        public List<MovimientoEntities> HistorialMovimiento { get; set; } = new List<MovimientoEntities>();
        public string Estado { get; set; }
    }
}
