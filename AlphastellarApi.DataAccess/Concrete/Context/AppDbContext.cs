using AlplastellarApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphastellarApi.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        public DbSet<Car>  Cars{ get; set; }
        public DbSet<Boat> Boats{ get; set; }
        public DbSet<Bus> Buses { get; set; }
    }
}
