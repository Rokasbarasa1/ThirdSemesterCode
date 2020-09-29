using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Session6_WebApp.Controllers
{
    [Route("[controller]")]
    public class TodoController : Controller
    {

        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            Console.WriteLine("Getting things");
            return _context.TodoItems;
        }

        [HttpGet("{id}")]
        public TodoItem Get(int id)
        {
            Console.WriteLine("IN get");
            Console.WriteLine(id);
            return _context.TodoItems.FirstOrDefault(t => t.Id == id);
        }

        // POST api/<controller>
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
            } catch(Exception e)
            {
                return BadRequest();
            }
            return CreatedAtAction("Get", new { id = item.Id }, item);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]TodoItem item)
        {
            Console.WriteLine("IN put");
            if (item == null | !ModelState.IsValid)
            {
                return BadRequest();
            }

            var todo = _context.TodoItems.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                _context.TodoItems.Add(item);
                _context.SaveChanges();
                return CreatedAtAction("Get", new { id = item.Id }, item);

            }
            else
            {
                _context.TodoItems.Remove(todo);
                _context.TodoItems.Add(item);
                _context.SaveChanges();
                return CreatedAtAction("Get", new { id = item.Id }, item);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Console.WriteLine("IN delete");
            var todo = _context.TodoItems.FirstOrDefault(t => t.Id == id);
            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
            return Ok();
        }
    }
}
