using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public class DetallePartidaEntities
    {
        public int DNI { get; set; }
        public TableroEntities PosicionActual { get; set; }
        public double DineroDisponible { get; set; }
        public List<MovimientoEntities> HistorialMovimiento { get; set; } = new List<MovimientoEntities>();
        public string Estado { get; set; }
        public int NumeroPartida { get; set; }
    }
}