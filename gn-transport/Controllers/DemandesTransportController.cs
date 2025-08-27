using gn_transport.Application.Commands;
using gn_transport.Application.Handlers;
using gn_transport.Application.Queries;
using Microsoft.AspNetCore.Mvc;
namespace gn_transport.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemandesTransportController : ControllerBase
    {
        private readonly CreerDemandeTransportCommandHandler _creerDemandeTransportHandler;
        private readonly GetDemandeTransportByIdQueryHandler _getDemandeTransportByIdHandler;
        private readonly ILogger<DemandesTransportController> _logger;
        public DemandesTransportController(
            CreerDemandeTransportCommandHandler creerDemandeTransportHandler,
            GetDemandeTransportByIdQueryHandler getDemandeTransportByIdHandler,
            ILogger<DemandesTransportController> logger)
        {
            _creerDemandeTransportHandler = creerDemandeTransportHandler;
            _getDemandeTransportByIdHandler = getDemandeTransportByIdHandler;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> CreerDemande([FromBody] CreerDemandeTransportCommand command)
        {
            try
            {
                _logger.LogInformation("Réception d'une demande de création de transport pour le produit {TypeProduit}", command.TypeProduit);
                var demande = await _creerDemandeTransportHandler.Handle(command, CancellationToken.None);
                return CreatedAtAction(nameof(GetDemandeById), new
                {
                    id =
                demande.Id
                }, demande);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erreur lors de la création de la demande de transport.");
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDemandeById(Guid id)
        {
            try
            {
                _logger.LogInformation("Réception d'une demande de récupération de transport par ID: {DemandeId}", id);
                var query = new GetDemandeTransportByIdQuery
                {
                    DemandeId = id
                };
                var demande = await
                _getDemandeTransportByIdHandler.Handle(query, CancellationToken.None);
                if (demande == null)
                {
                    return NotFound();
                }
                return Ok(demande);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erreur lors de la récupération de la demande de transport par ID.");
                return StatusCode(500, "Erreur interne du serveur");
            }
        }
        // Autres endpoints pour la gestion des offres, matching, etc.
    }
}
