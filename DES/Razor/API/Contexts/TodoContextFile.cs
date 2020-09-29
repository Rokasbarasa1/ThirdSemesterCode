using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace API.Contexts
{
    public class TodoContextFile
    {
		public List<TodoItem> readAllFromFile()
        {
			try
			{
				using(var sr = new StreamReader("file.txt"))
				{
					string line;
					List<TodoItem> todos = new List<TodoItem>();
					while((line = sr.ReadLine()) != null)
					{
						string[] divided = line.Split(";");
						TodoItem newItem = new TodoItem { Id = Int32.Parse(divided[0]), Name = divided[1]
							, Description = divided[2], IsComplete = Boolean.Parse(divided[3]) };
						todos.Add(newItem);
					}
					return todos;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return null;
        }

		public void writeToFile(TodoItem item)
		{
			try
			{
				using (var sw = new StreamWriter("file.txt", append: true))
				{
					sw.WriteLine(item.ToString());
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
