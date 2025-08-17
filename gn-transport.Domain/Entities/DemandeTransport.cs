using System;
using gn_transport.Domain.ValueObjects;
namespace gn_transport.Domain.Entities
{
    public class DemandeTransport
    {
        public Guid Id { get; private set; }
        public string TypeProduit { get; private set; }
        public double Quantite { get; private set; }
        public string UniteQuantite { get; private set; }
        public Localisation PointDepart { get; private set; }
        public Localisation PointArrivee { get; private set; }
        public DateTime DateHeureSouhaitee { get; private set; }
        public string Statut { get; private set; } // En attente, Acceptée, Encours, Livrée, Annulée
    public Guid DemandeurId { get; private set; }
        public DemandeTransport(string typeProduit, double quantite, string
        uniteQuantite, Localisation pointDepart, Localisation pointArrivee, DateTime
        dateHeureSouhaitee, Guid demandeurId)
        {
            Id = Guid.NewGuid();
            TypeProduit = typeProduit ?? throw new
            ArgumentNullException(nameof(typeProduit));
            Quantite = quantite;
            UniteQuantite = uniteQuantite ?? throw new
            ArgumentNullException(nameof(uniteQuantite));
            PointDepart = pointDepart ?? throw new
            ArgumentNullException(nameof(pointDepart));
            PointArrivee = pointArrivee ?? throw new
            ArgumentNullException(nameof(pointArrivee));
            DateHeureSouhaitee = dateHeureSouhaitee;
            Statut = "En attente";
            DemandeurId = demandeurId;
        }
        // Constructeur pour la reconstitution depuis la persistance
        public DemandeTransport(Guid id, string typeProduit, double quantite,
        string uniteQuantite, Localisation pointDepart, Localisation pointArrivee,
        DateTime dateHeureSouhaitee, string statut, Guid demandeurId)
        {
            Id = id;
            TypeProduit = typeProduit;
            Quantite = quantite;
            UniteQuantite = uniteQuantite;
            PointDepart = pointDepart;
            PointArrivee = pointArrivee;
            DateHeureSouhaitee = dateHeureSouhaitee;
            Statut = statut;
            DemandeurId = demandeurId;
        }
        public void AnnulerDemande()
        {
            if (Statut == "En attente")
            {
                Statut = "Annulée";
            }
            else
            {
                throw new InvalidOperationException("Impossible d'annuler unedemande qui n'est pas en attente.");
            }
        }
        public void AccepterDemande()
        {
            if (Statut == "En attente")
            {
                Statut = "Acceptée";
            }
            else
            {
                throw new InvalidOperationException("Impossible d'accepter unedemande qui n'est pas en attente.");
            }
        }
        // Autres méthodes métier pour la gestion de la demande
    }
}
