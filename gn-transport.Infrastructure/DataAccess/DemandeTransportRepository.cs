using gn_transport.Domain.Entities;
using System.Data;

namespace gn_transport.Infrastructure.DataAccess
{
    public class DemandeTransportRepository //: BaseRepository<DemandeTransport,Guid>, IDemandeTransportRepository
    {
        public DemandeTransportRepository(IDbConnection connection) //: base(connection)
        {
            // Mappage Dapper pour les objets de valeur
            //SqlMapper.AddTypeHandler(typeof(Localisation), new
            //LocalisationTypeHandler());
        }
        public async Task AddAsync(DemandeTransport demande)
        {
    //        var sql = "INSERT INTO DemandesTransport (Id, TypeProduit,
    //        Quantite, UniteQuantite, PointDepartLatitude, PointDepartLongitude,
    //PointDepartAdresse, PointDepartVille, PointDepartPays, PointArriveeLatitude,
    //PointArriveeLongitude, PointArriveeAdresse, PointArriveeVille,
    //PointArriveePays, DateHeureSouhaitee, Statut, DemandeurId) VALUES(@Id,
    //@TypeProduit, @Quantite, @UniteQuantite, @PointDepartLatitude,
    //@PointDepartLongitude, @PointDepartAdresse, @PointDepartVille,
    //@PointDepartPays, @PointArriveeLatitude, @PointArriveeLongitude,
    //@PointArriveeAdresse, @PointArriveeVille, @PointArriveePays,
    //@DateHeureSouhaitee, @Statut, @DemandeurId)";
    //        await _connection.ExecuteAsync(sql, new
    //        {
    //            demande.Id,
    //            demande.TypeProduit,
    //            demande.Quantite,
    //            demande.UniteQuantite,
    //            PointDepartLatitude = demande.PointDepart.Latitude,
    //            PointDepartLongitude = demande.PointDepart.Longitude,
    //            PointDepartAdresse = demande.PointDepart.Adresse,
    //            PointDepartVille = demande.PointDepart.Ville,
    //            PointDepartPays = demande.PointDepart.Pays,
    //            PointArriveeLatitude = demande.PointArrivee.Latitude,
    //            PointArriveeLongitude = demande.PointArrivee.Longitude,
    //            PointArriveeAdresse = demande.PointArrivee.Adresse,
    //            PointArriveeVille = demande.PointArrivee.Ville,
    //            PointArriveePays = demande.PointArrivee.Pays,
    //            demande.DateHeureSouhaitee,
    //            demande.Statut,
    //            demande.DemandeurId
    //        });
        }
        public async Task DeleteAsync(Guid id)
        {
            //var sql = "DELETE FROM DemandesTransport WHERE Id = @Id";
            //await _connection.ExecuteAsync(sql, new { Id = id });
        }
        public async Task<IEnumerable<DemandeTransport>> GetAllAsync()
        {
            //var sql = "SELECT * FROM DemandesTransport";
            //return await _connection.QueryAsync<DemandeTransport>(sql);
            return null;
        }
        public async Task<DemandeTransport> GetByIdAsync(Guid id)
        {
            //var sql = "SELECT * FROM DemandesTransport WHERE Id = @Id";
            //var result = await _connection.QuerySingleOrDefaultAsync<dynamic>
            //(sql, new { Id = id });
            //if (result == null) return null;
            //var pointDepart = new Localisation(result.PointDepartLatitude,
            //result.PointDepartLongitude, result.PointDepartAdresse,
            //result.PointDepartVille, result.PointDepartPays);
            //var pointArrivee = new Localisation(result.PointArriveeLatitude,
            //result.ArriveeLongitude, result.PointArriveeAdresse, result.PointArriveeVille,
            //result.PointArriveePays);
            //return new DemandeTransport(
            //result.Id,
            //result.TypeProduit,
            //result.Quantite,
            //result.UniteQuantite,
            //pointDepart,
            //pointArrivee,
            //result.DateHeureSouhaitee,
            //result.Statut,
            //result.DemandeurId
            //);
            return null;
        }
        public async Task<IEnumerable<DemandeTransport>> GetByDemandeurIdAsync(Guid demandeurId)
        {
            //    var sql = "SELECT * FROM DemandesTransport WHERE DemandeurId =
            //@DemandeurId";
            //var results = await _connection.QueryAsync<dynamic>(sql, new
            //{
            //    DemandeurId = demandeurId
            //});
            //    var demandes = new List<DemandeTransport>();
            //    foreach (var result in results)
            //    {
            //        var pointDepart = new Localisation(result.PointDepartLatitude,
            //        result.PointDepartLongitude, result.PointDepartAdresse,
            //        result.PointDepartVille, result.PointDepartPays);
            //        var pointArrivee = new
            //        Localisation(result.PointArriveeLatitude, result.PointArriveeLongitude,
            //        result.PointArriveeAdresse, result.PointArriveeVille, result.PointArriveePays);
            //        demandes.Add(new DemandeTransport(
            //        result.Id,
            //        result.TypeProduit,
            //        result.Quantite,
            //        result.UniteQuantite,
            //        pointDepart,
            //        pointArrivee,
            //        result.DateHeureSouhaitee,
            //        result.Statut,
            //        result.DemandeurId
            //        ));
            //    }
            //    return demandes;
            return null;
        }
        public async Task UpdateAsync(DemandeTransport demande)
        {
//            var sql = "UPDATE DemandesTransport SET TypeProduit = @TypeProduit, Quantite = @Quantite, UniteQuantite = @UniteQuantite, PointDepartLatitude =
//        @PointDepartLatitude, PointDepartLongitude = @PointDepartLongitude,
//PointDepartAdresse = @PointDepartAdresse, PointDepartVille = @PointDepartVille,
//PointDepartPays = @PointDepartPays, PointArriveeLatitude =
//@PointArriveeLatitude, PointArriveeLongitude = @PointArriveeLongitude,
//PointArriveeAdresse = @PointArriveeAdresse, PointArriveeVille =
//@PointArriveeVille, PointArriveePays = @PointArriveePays, DateHeureSouhaitee =
//@DateHeureSouhaitee, Statut = @Statut, DemandeurId = @DemandeurId WHERE Id =
//@Id";
//        await _connection.ExecuteAsync(sql, new
//        {
//            demande.TypeProduit,
//            demande.Quantite,
//            demande.UniteQuantite,
//            PointDepartLatitude = demande.PointDepart.Latitude,
//            PointDepartLongitude = demande.PointDepart.Longitude,
//            PointDepartAdresse = demande.PointDepart.Adresse,
//            PointDepartVille = demande.PointDepart.Ville,
//            PointDepartPays = demande.PointDepart.Pays,
//            PointArriveeLatitude = demande.PointArrivee.Latitude,
//            PointArriveeLongitude = demande.PointArrivee.Longitude,
//            PointArriveeAdresse = demande.PointArrivee.Adresse,
//            PointArriveeVille = demande.PointArrivee.Ville,
//            PointArriveePays = demande.PointArrivee.Pays,
//            demande.DateHeureSouhaitee,
//            demande.Statut,
//            demande.DemandeurId,
//            demande.Id
//        });
        }
        // Type handler pour le Value Object Localisation
        private class LocalisationTypeHandler// : SqlMapper.TypeHandler<Localisation>
        {
            //public override Localisation Parse(object value)
            //{
            //    // Cette méthode ne sera pas appelée directement pour les
            //    propriétés individuelles
            //throw new NotImplementedException();
            //}
            //public override void SetValue(IDbDataParameter parameter,
            //Localisation value)
            //{
            //    // Cette méthode ne sera pas appelée directement pour les
            //    propriétés individuelles
            //throw new NotImplementedException();
            //}
        }
    }
}