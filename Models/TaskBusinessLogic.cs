using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.Models
{
    public class TaskBusinessLogic
    {
        /// <summary>
        /// This list represents the tasks that are to be displayed
        /// </summary>
        public static List<TaskItem> taskList = new List<TaskItem>()
        {
            // Add a sample task
            new TaskItem("Submit Assignment", "LINQ course", DateTime.Now, false)
        };

        /// <summary>
        /// This methods adds a task to the list and returns a boolean value
        /// indicating whether the task was added or not
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public bool AddTask(TaskItem task)
        {
            taskList.Add(task);

            return true;
        }

        /// <summary>
        /// This method returns the list of tasks
        /// </summary>
        /// <returns></returns>
        public List<TaskItem> GetTaskItems()
        {
            return taskList;
        }
    }
}