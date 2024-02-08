using System;

namespace ToDoApplication.Models
{
    public class TaskItem
    {
        // Represents the task's title
        public string Title { get; set; }

        // Represents the task's details
        public string Description { get; set; }

        // Represents the task's due date
        public DateTime DueDate { get; set; }

        // Indicates whether the task is completed or not
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The default constructor
        /// </summary>
        public TaskItem()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="dueDate"></param>
        /// <param name="isCompleted"></param>
        public TaskItem(string title, string description, DateTime dueDate, bool isCompleted)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

    }
}