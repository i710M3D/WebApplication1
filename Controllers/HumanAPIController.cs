using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Db;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HumanAPIController : ControllerBase
    {
        private readonly IHumanService _humanService;
    
        public HumanAPIController( IHumanService HumanService)
        {
            _humanService = HumanService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Human>>> GetALL()
        {
           return await _humanService.GetALL();   
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Human>> GetSingal(int id)
        {
           return await _humanService.GetSingal(id);
        }
        [HttpPost]
        public async Task<ActionResult<List<Human>>> PostHuman(Human human)
        {
          return await _humanService.PostHuman(human);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Human>>> UpdateSingal(int id , Human req)
        {
            return await _humanService.UpdateSingal(id, req);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Human>>> DeleteHuman(int id)
        {
          return await _humanService.DeleteHuman(id);
        }
    }
}
