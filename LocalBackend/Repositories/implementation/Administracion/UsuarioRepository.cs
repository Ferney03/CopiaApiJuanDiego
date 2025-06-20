using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Administracion;
using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Administracion
{
    public class UsuarioRepository : GenericRepository<ClsMUsuario>, IUsuarioRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMUsuario>> GetAsync(Guid id)
        {
            var Usuario = await _context.Usuario
                .Include(c => c.IdUsuario!)
                .FirstOrDefaultAsync(c => c.IdUsuario == id);
            if (Usuario == null)
            {
                return new ActionResponse<ClsMUsuario>
                {
                    WasSuccess = false,
                    Message = "No existen registros de la actividad"
                };
            }

            return new ActionResponse<ClsMUsuario>
            {
                WasSuccess = true,
                Result = Usuario
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUsuario>>> GetAsync()
        {
            var Usuario = await _context.Usuario
                .Include(c => c.IdUsuario)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMUsuario>>
            {
                WasSuccess = true,
                Result = Usuario
            };
        }
    }
}
