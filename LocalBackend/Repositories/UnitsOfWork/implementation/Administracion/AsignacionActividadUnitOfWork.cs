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
    public class AsignacionActividadUnitOfWork : GenericUnitOfWork<ClsMAsignacionActividad>, IAsignacionActividadUnitOfWork
    {
        private readonly IAsignacionActividadRepository _asignacionactividadRepository;

        public AsignacionActividadUnitOfWork(IGenericRepository<ClsMAsignacionActividad> repository, IAsignacionActividadRepository asignacionactividadRepository) : base(repository)
        {
            _asignacionactividadRepository = asignacionactividadRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMAsignacionActividad>>> GetAsync() => await _asignacionactividadRepository.GetAsync();
        public override async Task<ActionResponse<ClsMAsignacionActividad>> GetAsync(Guid id) => await _asignacionactividadRepository.GetAsync(id);
    }
}
