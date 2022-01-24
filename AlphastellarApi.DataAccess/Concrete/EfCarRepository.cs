using AlphastellarApi.DataAccess.Abstract;
using AlphastellarApi.DataAccess.Concrete.EntityFramework;
using AlplastellarApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphastellarApi.DataAccess.Concrete
{
    public class EfCarRepository : EfRepository<Car, AppDbContext>
    {
        private AppDbContext _appDbContext;
        public EfCarRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
        public async Task<List<Car>> GetCarsByColorAsync(string color)
        {
            return await _appDbContext.Cars.Where(x => x.Color == color).ToListAsync();
        }

    }
}
