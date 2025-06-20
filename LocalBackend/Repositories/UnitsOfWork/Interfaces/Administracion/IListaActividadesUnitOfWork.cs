using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Administracion
{
    public interface IListaActividadesUnitOfWork
    {
        Task<ActionResponse<ClsMListaActividades>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMListaActividades>>> GetAsync();
    }
}
