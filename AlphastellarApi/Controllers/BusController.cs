using AlphastellarApi.DataAccess.Concrete;
using AlplastellarApi.Core;
using AlplastellarApi.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlphastellarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : MyMDBController<Bus, EfBusRepository>
    {
        private EfBusRepository _efBusRepository;
        public BusController(EfBusRepository repository) : base(repository)
        {
            _efBusRepository = repository;
        }
        // GET: api/[controller]/red
        [HttpGet(nameof(GetBusesByColor))]
        public async Task<ActionResult<IEnumerable<Bus>>> GetBusesByColor(string color)
        {
            return await _efBusRepository.GetBusesByColorAsync(color);
        }
    }
}
