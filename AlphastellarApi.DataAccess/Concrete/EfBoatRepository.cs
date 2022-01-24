using AlphastellarApi.DataAccess.Abstract;
using AlphastellarApi.DataAccess.Concrete.EntityFramework;
using AlplastellarApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphastellarApi.DataAccess.Concrete
{
    public class EfBoatRepository : EfRepository<Boat, AppDbContext>
    {
        private AppDbContext _appDbContext;
        public EfBoatRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
        public async Task<List<Boat>> GetBoatsByColorAsync(string color)
        {
            return await _appDbContext.Boats.Where(x => x.Color == color).ToListAsync();
        }

    }
}
