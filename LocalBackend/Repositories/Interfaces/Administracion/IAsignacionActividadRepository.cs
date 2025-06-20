using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.Interfaces.Administracion
{
    public interface IAsignacionActividadRepository
    {
        Task<ActionResponse<ClsMAsignacionActividad>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMAsignacionActividad>>> GetAsync();
    }
}
