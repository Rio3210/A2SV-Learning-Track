using System;


enum TaskCategory
{
    Personal,
    Work,
    Errands
}

class Task
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TaskCategory Category { get; set; }
    public bool IsCompleted { get; set; }

}


class TaskManager
{

    private List<Task> tasks = new List<Task>();
    private string filePath = "tasks.csv";

    public TaskManager()
    {
        // read the file and populate the list of tasks
        // if the file does not exist, create it
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
        else
        {
            // read the file and populate the list of tasks
            ReadFile();
        }
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
        WriteFile();
    }

    public void DisplayTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"Name: {task.Name}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Category: {task.Category}");
            Console.WriteLine($"Completed: {task.IsCompleted}");
            Console.WriteLine();
        }
    }

    public void DisplayTasks(TaskCategory category)
    {
        foreach (var task in tasks.Where(t => t.Category == category))
        {
            Console.WriteLine($"Name: {task.Name}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Category: {task.Category}");
            Console.WriteLine($"Completed: {task.IsCompleted}");
            Console.WriteLine();
        }
    }
    //based on completion status
    public void DisplayTasks(bool isCompleted)
    {
        foreach (var task in tasks.Where(t => t.IsCompleted == isCompleted))
        {
            Console.WriteLine($"Name: {task.Name}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Category: {task.Category}");
            Console.WriteLine($"Completed: {task.IsCompleted}");
            Console.WriteLine();
        }
    }

// below are function to read and write into our tasks.csv file
    private async void WriteFile()
    {
        try{
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var task in tasks)
            {
                await writer.WriteLineAsync($"{task.Name},{task.Description},{task.Category},{task.IsCompleted}");
            }
        }
        } 
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        
    }

    private async void ReadFile()
    {
        try{
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                string[] taskDetails = line.Split(',');
                Task task = new Task
                {
                    Name = taskDetails[0],
                    Description = taskDetails[1],
                    Category = (TaskCategory)Enum.Parse(typeof(TaskCategory), taskDetails[2]),
                    IsCompleted = bool.Parse(taskDetails[3])
                };
                tasks.Add(task);
            }
        }
    }
     
    catch(Exception ex){
        Console.WriteLine(ex.Message);
    }
    }
 } 


class Program {

    static void Main(string[] args){
        TaskManager taskManager = new TaskManager();
        taskManager.AddTask(new Task
        {
            Name = "Task 1",
            Description = "Description 1",
            Category = TaskCategory.Personal,
            IsCompleted = false
        });
        taskManager.AddTask(new Task
        {
            Name = "Task 2",
            Description = "Description 2",
            Category = TaskCategory.Work,
            IsCompleted = false
        });
        taskManager.AddTask(new Task
        {
            Name = "Task 3",
            Description = "Description 3",
            Category = TaskCategory.Errands,
            IsCompleted = false
        });
        taskManager.AddTask(new Task
        {
            Name = "Task 4",
            Description = "Description 4",
            Category = TaskCategory.Personal,
            IsCompleted = false
        });
        taskManager.AddTask(new Task
        {
            Name = "Task 5",
            Description = "Description 5",
            Category = TaskCategory.Work,
            IsCompleted = false
        });
        taskManager.AddTask(new Task
        {
            Name = "Task 6",
            Description = "Description 6",
            Category = TaskCategory.Errands,
            IsCompleted = true
        });

        taskManager.DisplayTasks();
        taskManager.DisplayTasks(TaskCategory.Personal);
        taskManager.DisplayTasks(TaskCategory.Work);
        taskManager.DisplayTasks(TaskCategory.Errands);
        //to display tasks based on completion status
        taskManager.DisplayTasks(true);


    }
}









