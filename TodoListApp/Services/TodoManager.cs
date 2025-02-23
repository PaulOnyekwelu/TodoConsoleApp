using System;
using System.Collections.Generic;
using System.Linq;
using TodoListApp.Models;

namespace TodoListApp.Services
{
    public class TodoManager
    {
        public List<TodoItem> tasks = [];

        public void AddTask(string description)
        {
            int newId = tasks.Count > 0 ? tasks.Max(tk => tk.Id) + 1 : 1;

            TodoItem newTask = new TodoItem(newId, description);
            tasks.Add(newTask);

            Console.WriteLine("✅ Task Added!");
        }

        public void MarkTaskAsCompleted (int _id)
        {
            var task = tasks.FirstOrDefault(tk => tk.Id == _id);

            if (task == null)
            {
                //new Exception($"Task doesn't exist for id: {_id}");
                Console.WriteLine($"Task with id, ({_id}) not found!");
            } else
            {
                task.MarkAsCompleted();
                Console.WriteLine($"Task ({task.Description}), completed!");
            }
        }

        public void RemoveTask(int _id)
        {
            var task = tasks.FirstOrDefault( tk => tk.Id == _id);

            if(task == null)
            {
                Console.WriteLine($"Task with id, ({_id}) not found!");
            }else
            {
                tasks.Remove(task);
                Console.WriteLine($"Task ({task.Description}), removed!");
            }
        }

        public void ListTasks ()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("📭 No tasks available.");
            } else
            {
                Console.WriteLine("\n📝 To-Do List:");
                foreach (TodoItem task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
