using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstancieroDigitalData
{
    public class EstadisticaEntities
    {
        public List<PartidaEntities> PartidasJugadas { get; set; } = new List<PartidaEntities>();
        public List<PartidaEntities> PartidasGanadas { get; set; } = new List<PartidaEntities>();
        public List<PartidaEntities> PartidasPerdidas { get; set; } = new List<PartidaEntities>();
        public List<PartidaEntities> PartidasPendientes { get; set; } = new List<PartidaEntities>();
    }
}