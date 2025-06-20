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
    public class UpaUnitOfWork : GenericUnitOfWork<ClsMUpa>, IUpaUnitOfWork
    {
        private readonly IUpaRepository _upasRepository;

        public UpaUnitOfWork(IGenericRepository<ClsMUpa> repository, IUpaRepository upasRepository) : base(repository)
        {
            _upasRepository = upasRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUpa>>> GetAsync() => await _upasRepository.GetAsync();
        public override async Task<ActionResponse<ClsMUpa>> GetAsync(Guid id) => await _upasRepository.GetAsync(id);
    }
}
