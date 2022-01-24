using AlphastellarApi.DataAccess.Concrete;
using AlplastellarApi.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlphastellarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : MyMDBController<Boat, EfBoatRepository>
    {
        private EfBoatRepository _efBoatRepository;
        public BoatController(EfBoatRepository repository) : base(repository)
        {
            _efBoatRepository = repository;
        }
        // GET: api/[controller]/red
        [HttpGet(nameof(GetBoatsByColor))]
        public async Task<ActionResult<IEnumerable<Boat>>> GetBoatsByColor(string color)
        {
            return await _efBoatRepository.GetBoatsByColorAsync(color);
        }
    }
}
