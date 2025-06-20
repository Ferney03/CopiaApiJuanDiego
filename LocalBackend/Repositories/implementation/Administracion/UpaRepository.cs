using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Administracion;
using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Administracion
{
    public class UpaRepository : GenericRepository<ClsMUpa>, IUpaRepository
    {
        private readonly DataContext _context;

        public UpaRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMUpa>> GetAsync(Guid id)
        {
            var Upa = await _context.Upa
                .Include(c => c.IdUpa!)
                .FirstOrDefaultAsync(c => c.IdUpa == id);
            if (Upa == null)
            {
                return new ActionResponse<ClsMUpa>
                {
                    WasSuccess = false,
                    Message = "No existen registros de la actividad"
                };
            }

            return new ActionResponse<ClsMUpa>
            {
                WasSuccess = true,
                Result = Upa
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMUpa>>> GetAsync()
        {
            var Upa = await _context.Upa
                .Include(c => c.IdUpa)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMUpa>>
            {
                WasSuccess = true,
                Result = Upa
            };
        }
    }
}
