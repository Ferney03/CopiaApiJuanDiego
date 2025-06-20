using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Administracion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : GenericController<ClsMUsuario>
    {
        public UsuarioController(IGenericUnitOfWork<ClsMUsuario> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
