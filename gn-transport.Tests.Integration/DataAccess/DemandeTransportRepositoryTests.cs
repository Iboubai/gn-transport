// Pour SQL Server
namespace gn_transport.Tests.Integration.DataAccess
{
    [TestFixture]
    public class DemandeTransportRepositoryTests
    {
        //private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=TestTransportDb;Integrated Security = True;";
        //private SqlConnection _connection;
        //private DemandeTransportRepository _repository;
        [SetUp]
        public async Task Setup()
        {
            //_connection = new SqlConnection(_connectionString);
            //await _connection.OpenAsync();
            //_repository = new DemandeTransportRepository(_connection);
            //// Assurez-vous que la table existe et est vide avant chaque test
            //await CreateTableAndClearData();
        }
        [TearDown]
        public async Task TearDown()
        {
            //await _connection.CloseAsync();
            //_connection.Dispose();
        }
        private async Task CreateTableAndClearData()
        {
            //            var createTableSql = @"IF OBJECT_ID('DemandesTransport', 'U') IS
            //NULL
            //CREATE TABLE DemandesTransport (
            //Id UNIQUEIDENTIFIER PRIMARY KEY,
            //TypeProduit NVARCHAR(255) NOT NULL,
            //Quantite FLOAT NOT NULL,
            //UniteQuantite NVARCHAR(50) NOT NULL,
            //PointDepartLatitude FLOAT NOT NULL,
            //PointDepartLongitude FLOAT NOT NULL,
            //PointDepartAdresse NVARCHAR(MAX) NOT
            //NULL,
            //PointDepartVille NVARCHAR(255) NOT NULL,
            //PointDepartPays NVARCHAR(255) NOT NULL,
            //PointArriveeLatitude FLOAT NOT NULL,
            //PointArriveeLongitude FLOAT NOT NULL,
            //PointArriveeAdresse NVARCHAR(MAX) NOT
            //NULL,
            //PointArriveeVille NVARCHAR(255) NOT
            //NULL,
            //PointArriveePays NVARCHAR(255) NOT NULL,
            //DateHeureSouhaitee DATETIME2 NOT NULL,
            //Statut NVARCHAR(50) NOT NULL,
            //DemandeurId UNIQUEIDENTIFIER NOT NULL
            //);
            //DELETE FROM DemandesTransport;";
            //            await _connection.ExecuteAsync(createTableSql);
        }
        [Test]
        public async Task AddAsync_DoitAjouterUneDemandeTransport()
        {
            //// Arrange
            //var pointDepart = new Localisation(48.8566, 2.3522, "1 Rue de la Paix", "Paris", "France");
            //var pointArrivee = new Localisation(45.7640, 4.8357, "2 Avenue des Lumières", "Lyon", "France");
            //var demandeurId = Guid.NewGuid();
            //var demande = new DemandeTransport("Céréales", 1000, "kg",
            //pointDepart, pointArrivee, DateTime.Now.AddDays(1), demandeurId);
            //// Act
            //await _repository.AddAsync(demande);
            //// Assert
            //var retrievedDemande = await _repository.GetByIdAsync(demande.Id);
            //Assert.IsNotNull(retrievedDemande);
            //Assert.AreEqual(demande.Id, retrievedDemande.Id);
            //Assert.AreEqual(demande.TypeProduit, retrievedDemande.TypeProduit);
            //Assert.AreEqual(demande.PointDepart.Adresse,
            //retrievedDemande.PointDepart.Adresse);
        }
        [Test]
        public async Task
        GetByDemandeurIdAsync_DoitRetournerLesDemandesDuDemandeur()
        {
            // Arrange
            //var demandeurId1 = Guid.NewGuid();
            //var demandeurId2 = Guid.NewGuid();
            //var pointDepart = new Localisation(48.8566, 2.3522, "1 Rue de la Paix", "Paris", "France");
            //var pointArrivee = new Localisation(45.7640, 4.8357, "2 Avenue des Lumières", "Lyon", "France");
            //await _repository.AddAsync(new DemandeTransport("Céréales", 1000,
            //"kg", pointDepart, pointArrivee, DateTime.Now.AddDays(1), demandeurId1));
            //await _repository.AddAsync(new DemandeTransport("Fruits", 500,
            //"kg", pointDepart, pointArrivee, DateTime.Now.AddDays(2), demandeurId1));
            //await _repository.AddAsync(new DemandeTransport("Légumes", 200,
            //"kg", pointDepart, pointArrivee, DateTime.Now.AddDays(3), demandeurId2));
            //// Act
            //var demandesDemandeur1 = (await
            //_repository.GetByDemandeurIdAsync(demandeurId1)).ToList();
            //// Assert
            //Assert.AreEqual(2, demandesDemandeur1.Count);
            //Assert.IsTrue(demandesDemandeur1.All(d => d.DemandeurId == demandeurId1));
        }
    }
}