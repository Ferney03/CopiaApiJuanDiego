using LocalShare.Responses;
using LocalShared.Entities.Administracion;

namespace LocalBackend.Repositories.Interfaces.Administracion
{
    public interface IListaActividadesRepository
    {
        Task<ActionResponse<ClsMListaActividades>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMListaActividades>>> GetAsync();
    }
}
