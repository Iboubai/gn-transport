using gn_transport.Domain.Entities;
using gn_transport.Domain.ValueObjects;
namespace gn_transport.Tests.Unit.Domain
{
    [TestFixture]
    public class DemandeTransportTests
    {
        [Test]
        public void CreerDemandeTransport_AvecDonneesValides_DoitCreerDemande()
        {
            // Arrange
            var pointDepart = new Localisation(48.8566, 2.3522, "1 Rue de la Paix", "Paris", "France");
            var pointArrivee = new Localisation(45.7640, 4.8357, "2 Avenue des Lumières", "Lyon", "France");
            var demandeurId = Guid.NewGuid();
            // Act
            var demande = new DemandeTransport("Céréales", 1000, "kg",
            pointDepart, pointArrivee, DateTime.Now.AddDays(1), demandeurId);
            // Assert
            Assert.IsNotNull(demande.Id);
            Assert.AreEqual("Céréales", demande.TypeProduit);
            Assert.AreEqual("En attente", demande.Statut);
            Assert.AreEqual(demandeurId, demande.DemandeurId);
        }
        [Test]
        public void AnnulerDemande_QuandEnAttente_DoitChangerStatutEnAnnulee()
        {
            // Arrange
            var pointDepart = new Localisation(48.8566, 2.3522, "1 Rue de la Paix", "Paris", "France");
            var pointArrivee = new Localisation(45.7640, 4.8357, "2 Avenue des Lumières", "Lyon", "France");
            var demandeurId = Guid.NewGuid();
            var demande = new DemandeTransport("Céréales", 1000, "kg",
            pointDepart, pointArrivee, DateTime.Now.AddDays(1), demandeurId);
            // Act
            demande.AnnulerDemande();
            // Assert
            Assert.AreEqual("Annulée", demande.Statut);
        }
        [Test]
        public void AnnulerDemande_QuandPasEnAttente_DoitLeverException()
        {
            // Arrange
            var pointDepart = new Localisation(48.8566, 2.3522, "1 Rue de la Paix", "Paris", "France");
            var pointArrivee = new Localisation(45.7640, 4.8357, "2 Avenue des Lumières", "Lyon", "France");
            var demandeurId = Guid.NewGuid();
            var demande = new DemandeTransport("Céréales", 1000, "kg",
            pointDepart, pointArrivee, DateTime.Now.AddDays(1), demandeurId);
            demande.AccepterDemande(); // Change status to Accepted
                                       // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>
            demande.AnnulerDemande());
        }
    }
}
