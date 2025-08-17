using gn_transport.Domain.Ports.Output;
using gn_transport.Domain.ValueObjects;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace gn_transport.Infrastructure.Services
{
    public class GeolocalisationServiceAdapter : IGeolocalisationService
    {
        private readonly HttpClient _httpClient;
        private readonly string _geolocApiBaseUrl;
        public GeolocalisationServiceAdapter(HttpClient httpClient,
            IConfiguration configuration)
        {
            _httpClient = httpClient;
            _geolocApiBaseUrl =
                configuration["Microservices:GeolocApi:BaseUrl"] ?? throw new
                    ArgumentNullException("GeolocApi:BaseUrl configuration is missing.");
        }
        public async Task<double> CalculerDistanceAsync(Localisation
            pointDepart, Localisation pointArrivee)
        {
            // Appel à l'API gn-geoloc pour calculer la distance
            var requestUrl = $"{_geolocApiBaseUrl}/api/geoloc/distance?lat1={ pointDepart.Latitude}&lon1 ={ pointDepart.Longitude}&lat2 ={ pointArrivee.Latitude}&lon2 ={ pointArrivee.Longitude}";
            var response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<double>(content);
        }
        public async Task<Localisation>
            ObtenirLocalisationActuelleTransporteurAsync(Guid transporteurId)
        {
            // Appel à l'API gn-geoloc pour obtenir la position actuelle d'un transporteur
            var requestUrl = $"{_geolocApiBaseUrl}/api/geoloc/transporteur/{transporteurId}/current - location";
            var response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            // Supposons que l'API gn-geoloc retourne un DTO mappable à Localisation
            return JsonConvert.DeserializeObject<Localisation>(content);
        }
    }
}