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
    public class CarController : MyMDBController<Car, EfCarRepository>
    {
        private EfCarRepository _efCarRepository;
        public CarController(EfCarRepository repository) : base(repository)
        {
            _efCarRepository = repository;
        }
        // GET: api/[controller]/red
        [HttpGet(nameof(GetCarsByColor))]
        public async Task<ActionResult<IEnumerable<Car>>> GetCarsByColor(string color)
        { 
           return await _efCarRepository.GetCarsByColorAsync(color);
        }       
    }
}
