using LocalBackend.Repositories.Interfaces.Dispositivos;
using LocalBackend.Repositories.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.implementation.Mediciones;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShare.Responses;
using LocalShared.Entities.Dispositivos;
using LocalBackend.Repositories.Interfaces.Administracion;
using LocalShared.Entities.Administracion;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Administracion;

namespace LocalBackend.Repositories.UnitsOfWork.implementation.Administracion
{
    public class UsuarioUnitOfWork : GenericUnitOfWork<ClsMUsuario>, IUsuarioUnitOfWork
    {
        private readonly IUsuarioRepository _usuariosRepository;

        public UsuarioUnitOfWork(IGenericRepository<ClsMUsuario> repository, IUsuarioRepository usuariosRepository) : base(repository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUsuario>>> GetAsync() => await _usuariosRepository.GetAsync();
        public override async Task<ActionResponse<ClsMUsuario>> GetAsync(Guid id) => await _usuariosRepository.GetAsync(id);
    }
}
