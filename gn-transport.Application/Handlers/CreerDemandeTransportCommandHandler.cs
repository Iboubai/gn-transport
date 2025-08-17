using gn_transport.Domain.Ports.Input;
using gn_transport.Application.Commands;
using gn_transport.Domain.Entities;
namespace gn_transport.Application.Handlers
{
    public class CreerDemandeTransportCommandHandler
    {
        private readonly IGestionDemandeTransportService
            _gestionDemandeTransportService;
        public
            CreerDemandeTransportCommandHandler(IGestionDemandeTransportService
                gestionDemandeTransportService)
        {
            _gestionDemandeTransportService = gestionDemandeTransportService;
        }
        public async Task<DemandeTransport> Handle(CreerDemandeTransportCommand
            command, CancellationToken cancellationToken)
        {
            return await
                _gestionDemandeTransportService.CreerDemandeTransportAsync(
                    command.TypeProduit,
                    command.Quantite,
                    command.UniteQuantite,
                    command.PointDepart,
                    command.PointArrivee,
                    command.DateHeureSouhaitee,
                    command.DemandeurId
                );
        }
    }
}