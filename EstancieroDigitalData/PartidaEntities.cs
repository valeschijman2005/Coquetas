using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public class PartidaEntities
    {
        public int NumeroPartida { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public double Duracion { get; set; }
        public string Estado { get; set; }
        public TurnoEntities TurnoActual { get; set; }
        public List<TurnoEntities> ConfiguracionTurno { get; set; } = new List<TurnoEntities>();
        public List<DetallePartidaEntities> DetallePartida { get; set; } 
        public UsuarioEntities? Ganador { get; set; }
        public string? MotivoVictoria { get; set; }
    }
}