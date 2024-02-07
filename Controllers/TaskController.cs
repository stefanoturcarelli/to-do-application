using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            TaskBusinessLogic tbl = new TaskBusinessLogic();

            var tasks = tbl.GetTaskItems();

            return View(tasks);
        }

        public ActionResult AddTask(string Title, string Description, DateTime DueDate)
        {
            TaskBusinessLogic tbl = new TaskBusinessLogic();

            TaskItem ti = new TaskItem(Title, Description, DueDate, false);
            //TaskItem ti = new TaskItem();

            //ti.Id = Id;
            //ti.Title = Title;
            //ti.Description = Description;
            //ti.DueDate = DueDate;
            //ti.IsCompleted = false;

            if (tbl.AddTask(ti))
            {
                return RedirectToAction("Index");
            }

            return null;
        }

        //public ActionResult DisplayTasks()
        //{
        //    TaskBusinessLogic tbl = new TaskBusinessLogic();

        //    var tasks = tbl.GetTaskItems();

        //    return View(tasks);
        //}
    }
}
