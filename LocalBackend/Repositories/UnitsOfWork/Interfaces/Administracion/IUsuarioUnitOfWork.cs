using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Administracion
{
    public interface IUsuarioUnitOfWork
    {
        Task<ActionResponse<ClsMUsuario>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMUsuario>>> GetAsync();
    }
}
