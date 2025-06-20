using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Administracion
{
    public interface IAsignacionActividadUnitOfWork
    {
        Task<ActionResponse<ClsMAsignacionActividad>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMAsignacionActividad>>> GetAsync();
    }
}
