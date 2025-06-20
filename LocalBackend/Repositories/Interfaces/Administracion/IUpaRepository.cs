using LocalShare.Responses;
using LocalShared.Entities.Administracion;

namespace LocalBackend.Repositories.Interfaces.Administracion
{
    public interface IUpaRepository
    {
        Task<ActionResponse<ClsMUpa>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMUpa>>> GetAsync();
    }
}
