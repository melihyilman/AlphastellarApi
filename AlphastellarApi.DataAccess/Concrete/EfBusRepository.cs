using AlphastellarApi.DataAccess.Abstract;
using AlphastellarApi.DataAccess.Concrete.EntityFramework;
using AlplastellarApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphastellarApi.DataAccess.Concrete
{
    public class EfBusRepository : EfRepository<Bus, AppDbContext>
    {
        private AppDbContext _appDbContext;
        public EfBusRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
        public async Task<List<Bus>> GetBusesByColorAsync(string color)
        {
            return await _appDbContext.Buses.Where(x => x.Color == color).ToListAsync();
        }

    }
}
