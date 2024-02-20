# ToDoApplication

## Task Controller

```csharp
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

            if (tbl.AddTask(ti))
            {
                return RedirectToAction("Index");
            }

            return null;
        }
    }
```

## Models

### TaskItem Class

```csharp
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
```

### TaskBusinessLogic Class

```csharp
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
        /// This method adds a task to the list and returns a boolean value
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
```

## View Index.cshtml

```cshtml
  ﻿@model List<ToDoApplication.Models.TaskItem>

  <div class="form-container">
      @using (Html.BeginForm("AddTask", "Task"))
      {
          <div>
              <h2>Add new tasks here: </h2>
          </div>
          <div>
              <span>Title</span>
              @Html.TextBox("Title", null, new { @class = "text-input" })
              <span>Description</span>
              @Html.TextBox("Description", null, new { @class = "text-input" })
              <span>Due Date</span>
              @Html.TextBox("DueDate", null, new { type = "datetime-local" })
              @*<td>@Html.TextBox("DueDate", null, new { type = "date" })</td>*@
              <div>
                  <input class="submit-button" type="Submit" , value="Add" />
              </div>
          </div>
      }
  </div>

  <table>
        <tr>
            <th>Title</th>
            <th>Description</th>
            <th>Due Date</th>
            <th>Is Completed</th>
        </tr>
        @foreach (var ti in Model)
        {
            <tr>
                <td>@ti.Title</td>
                <td>@ti.Description</td>
                <td>@ti.DueDate</td>
                <td>@ti.IsCompleted</td>
            </tr>
        }
  </table>
```

![image](https://github.com/stefanoturcarelli/ToDoApplication/assets/67341828/570107a4-f765-4cd2-95d3-66a050ba9aa1)
