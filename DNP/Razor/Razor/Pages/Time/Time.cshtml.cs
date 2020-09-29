using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Razor.Pages
{
    public class TimeModel : PageModel
    {
        public HttpHandler database = HttpHandler.getInstance();
        public List<TodoItem> todos = new List<TodoItem>();
        public string message { get; set; }
        [BindProperty]
        public TodoItem todo { get; set;}
        public void OnGet()
        {
            GetList();
            message = "Message from model";
        }

        public string placeString(string value)
        {
            value = "Model says " + value;
            return value;
        }

        public void OnPost() 
        {
            if(ModelState.IsValid != false)
            {
                database.PostPR("https://localhost:5001/Todo", System.Text.Json.JsonSerializer.Serialize(todo));
                Console.WriteLine("adding todo");
                GetList();
            }
        }

        private void GetList()
        {
            string values = database.GetPR("https://localhost:5001/Todo");
            Console.WriteLine(values);
            if (!values.Equals("false"))
            {
                todos = JsonConvert.DeserializeObject<List<TodoItem>>(values);
            }
        }
    }
}