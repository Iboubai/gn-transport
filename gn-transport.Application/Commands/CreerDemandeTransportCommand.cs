using System;
using gn_transport.Domain.ValueObjects;
namespace gn_transport.Application.Commands
{
    public class CreerDemandeTransportCommand
    {
        public string TypeProduit { get; set; }
        public double Quantite { get; set; }
        public string UniteQuantite { get; set; }
        public Localisation PointDepart { get; set; }
        public Localisation PointArrivee { get; set; }
        public DateTime DateHeureSouhaitee { get; set; }
        public Guid DemandeurId { get; set; }
    }

}