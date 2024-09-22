using Microsoft.AspNetCore.Mvc;
using GorevYonetici.Models;
using GorevYonetici.Data;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GorevYonetici.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public TasksController(MongoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gorev>>> GetTasks()
        {
            var tasks = await _context.Gorevler.Find(new BsonDocument()).ToListAsync();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<ActionResult> AddTask([FromBody] Gorev task)
        {
            await _context.Gorevler.InsertOneAsync(task);
            return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
        }
    }
}
