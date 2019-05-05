using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Week2Capstone
{
    class TaskList
    {
        public static Task task1 = new Task("Take out the trash", "01/02/2019", "Brad");
        public static Task task2 = new Task("Eat your greens", "02/02/2019", "Brittany");
        public static Task task3 = new Task("Learn to do Backflips", "04/02/2019", "John");
        public List<Task> tasks = new List<Task> { task1, task2, task3 };

        public void Options()
        {
            int numChoice = 0;
            Console.WriteLine("What Would you like to do? Choose 1-5:" +
                "\n         1) List tasks" +
                "\n         2) Add task" +
                "\n         3) Delete task" +
                "\n         4) Mark task complete" +
                "\n         5) Quit");

            Validate.OptionValidate(Console.ReadLine(), out numChoice);
            switch(numChoice)
            {
                case 1:
                    ListTasks();
                    break;
                case 2:
                    AddTask();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    MarkComplete();
                    break;
                case 5:
                    Console.WriteLine("See ya later");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("HUUUUUUGE error");
                    break;
            }
        }

        public void ListTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"Task{i + 1}:             {tasks[i].TaskName}" +
                                $"\nStudent Name:      {tasks[i].UserName}" +
                                $"\nDue Date:          {tasks[i].DueDate}" +
                                $"\nCompletion Status: {tasks[i].Status}\n");
            }
            Options();
        }

        public void AddTask()
        {
            string taskName;
            string taskDate;
            string userName;

            Console.WriteLine("Please enter the task:");
            taskName = Console.ReadLine();
            Console.WriteLine("Please enter the date it should be completed by (MM/DD/YYYY):");
            Validate.IsDate(Console.ReadLine(), out taskDate);
            Console.WriteLine("Who is assigned this task?");
            userName = Console.ReadLine();

            this.tasks.Add(new Task(taskName, taskDate, userName));
            Options();

        }

        public void DeleteTask()
        {
            if(tasks.Count == 0)
            {
                Console.WriteLine("There aren't any tasks to delete.");
                Options();
            }
            int choice;
            Console.WriteLine("Which task would you like to delete?\n");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {tasks[i].TaskName}");
            }
            Console.WriteLine($"Select task to remove 1 - {tasks.Count}");
            Validate.IsInRange(Console.ReadLine(), 1, tasks.Count, out choice);
            Console.WriteLine($"{tasks[choice - 1].TaskName} has been marked deleted...\n");
            tasks.RemoveAt(choice-1);
            Options();

        }

        public void MarkComplete()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("There aren't any tasks to complete.");
                Options();
            }
            int choice;
            Console.WriteLine("Which task would you like to mark complete?\n");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {tasks[i].TaskName}");
            }
            Console.WriteLine($"Select task to mark complete 1 - {tasks.Count}");
            Validate.IsInRange(Console.ReadLine(), 1, tasks.Count, out choice);
            tasks[choice - 1].IsComplete = true;
            Console.WriteLine($"{tasks[choice-1].TaskName} has been marked complete...\n");
            Options();

        }
    }
}
