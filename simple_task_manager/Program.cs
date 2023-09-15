using System;

using TaskManager;


class Program {

    static void Main(string[] args){
        
        TaskManager.TaskManager taskManager = new TaskManager.TaskManager();
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









