using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Administracion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListaActividadesController : GenericController<ClsMListaActividades>
    {
        public ListaActividadesController(IGenericUnitOfWork<ClsMListaActividades> unitOfWork) : base(unitOfWork)
        {
        }
    }
}