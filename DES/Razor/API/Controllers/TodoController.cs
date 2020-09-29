using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        
        private readonly TodoContextDatabase _context;

        public TodoController(TodoContextDatabase _context)
        {
            this._context = _context;
            if(_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }
          
        }

        /*
        private readonly TodoContextFile _context;

        public TodoController()
        {
            _context = new TodoContextFile();
            if (_context.readAllFromFile() == null)
            {
                _context.writeToFile(new TodoItem { Name = "Item1" });
            }

        }
        
        //todo
        [HttpGet]
        public async Task<List<TodoItem>> Get()
        {
            return _context.readAllFromFile();
        }

        [HttpPost]
        public async Task<IActionResult> PostShift(TodoItem todo)
        {
            _context.writeToFile(todo);
            return Ok();
        }

        //todo/1
        [HttpGet("{id}")]
        public async Task<TodoItem> Get(int id)
        {
            List<TodoItem> todos = _context.readAllFromFile();
            for (int i = 0; i < todos.Count; i++)
            {
                if(todos[i].Id == id)
                {
                    return todos[i];
                }
            }
            return null;
        }
        */

        //todo
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            Console.WriteLine("Getting things");
            return _context.TodoItems;
        }

        [HttpPost]
        public IActionResult Post([FromBody]TodoItem item)
        {
            Console.WriteLine("IN post");
            if (item == null | !ModelState.IsValid)
            {
                return BadRequest();
            }
            Console.WriteLine(item.Id);
            _context.TodoItems.Add(item);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }









        /*
        //todo?name = Toilet&id= 1
        [HttpGet]
        public async Task<TodoItem> Get([FromQuery(Name = "Name")] string Name, [FromQuery(Name = "IsComplete")] string IsComplete)
        {
            return 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveShift(int id)
        {
            return 
        }
        */

    }
}