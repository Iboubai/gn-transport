using gn_transport.Domain.Entities;
using gn_transport.Domain.ValueObjects;
namespace gn_transport.Domain.Ports.Input
{
    public interface IGestionDemandeTransportService
    {
        Task<DemandeTransport> CreerDemandeTransportAsync(string typeProduit,
            double quantite, string uniteQuantite, Localisation pointDepart, Localisation
                pointArrivee, DateTime dateHeureSouhaitee, Guid demandeurId);
        Task<DemandeTransport> GetDemandeTransportByIdAsync(Guid id);
        Task<IEnumerable<DemandeTransport>>
            GetDemandesTransportByDemandeurIdAsync(Guid demandeurId);
        Task AnnulerDemandeTransportAsync(Guid id);
        Task AccepterDemandeTransportAsync(Guid id);
        // Autres méthodes pour la gestion des offres, matching, etc.
    }
}