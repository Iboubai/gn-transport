using gn_transport.Domain.ValueObjects;

namespace gn_transport.Domain.Ports.Output;

public interface IGeolocalisationService
{
    Task<double> CalculerDistanceAsync(Localisation pointDepart, Localisation pointArrivee);
    Task<Localisation> ObtenirLocalisationActuelleTransporteurAsync(Guid transporteurId);
}