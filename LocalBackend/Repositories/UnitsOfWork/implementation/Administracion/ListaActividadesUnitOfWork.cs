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
    public class ListaActividadesUnitOfWork : GenericUnitOfWork<ClsMListaActividades>, IListaActividadesUnitOfWork
    {
        private readonly IListaActividadesRepository _listaactividadesRepository;

        public ListaActividadesUnitOfWork(IGenericRepository<ClsMListaActividades> repository, IListaActividadesRepository listaactividadesRepository) : base(repository)
        {
            _listaactividadesRepository = listaactividadesRepository;
        }

        public override async Task<ActionResponse<IEnumerable<ClsMListaActividades>>> GetAsync() => await _listaactividadesRepository.GetAsync();
        public override async Task<ActionResponse<ClsMListaActividades>> GetAsync(Guid id) => await _listaactividadesRepository.GetAsync(id);
    }
}
