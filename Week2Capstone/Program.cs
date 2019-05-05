using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Week2Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the task list organizer!");
            TaskList tasklist = new TaskList();
            tasklist.Options();
        }
    }
}
