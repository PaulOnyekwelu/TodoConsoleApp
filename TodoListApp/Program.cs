using TodoListApp.Services;

namespace TodoListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoManager tasks = new TodoManager();
            tasks.AddTask("Peace of Mind");
            tasks.AddTask("Second Task");
            //Console.WriteLine(tasks.ToString());
            tasks.MarkTaskAsCompleted(2);
            tasks.ListTasks();
        }
    }
}
