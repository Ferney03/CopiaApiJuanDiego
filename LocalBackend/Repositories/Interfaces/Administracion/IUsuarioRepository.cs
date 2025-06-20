using LocalShare.Responses;
using LocalShared.Entities.Administracion;

namespace LocalBackend.Repositories.Interfaces.Administracion
{
    public interface IUsuarioRepository
    {
        Task<ActionResponse<ClsMUsuario>> GetAsync(Guid id);
        Task<ActionResponse<IEnumerable<ClsMUsuario>>> GetAsync();
    }
}
