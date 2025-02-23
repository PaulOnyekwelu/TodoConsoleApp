using System;

namespace TodoListApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        // constructor to initialize a class
        public TodoItem(int id, string description)
        {
            this.Id = id;
            this.Description = description;
            this.IsCompleted = false;
        }

        // to mark task as completed
        public void MarkAsCompleted()
        {
            this.IsCompleted = true;
        }

        // format task output nicely
        public override string ToString()
        {
            return $"[{(IsCompleted ? "✔" : " ")}] {this.Id}: {Description}";
        }

    }
}
