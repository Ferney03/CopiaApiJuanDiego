using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;

namespace LocalBackend.Repositories.UnitsOfWork.Interfaces.Administracion
{
    public interface IUpaUnitOfWork
    {
        Task<ActionResponse<ClsMUpa>> GetAsync(Guid Id);
        Task<ActionResponse<IEnumerable<ClsMUpa>>> GetAsync();
    }
}
