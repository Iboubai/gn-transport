using gn_transport.Domain.Entities;

namespace gn_transport.Domain.Ports.Output
{
    public interface IDemandeTransportRepository
    {
        Task<DemandeTransport> GetByIdAsync(Guid id);
        Task<IEnumerable<DemandeTransport>> GetAllAsync();
        Task AddAsync(DemandeTransport demande);
        Task UpdateAsync(DemandeTransport demande);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<DemandeTransport>> GetByDemandeurIdAsync(Guid
            demandeurId);
    }
}