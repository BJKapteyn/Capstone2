using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Week2Capstone
{
    class Task
    {
        public string TaskName { get; private set; }
        public string DueDate { get; set; }
        public string UserName { get; private set; }
        public bool IsComplete { get; set; } = false;
        public string Status
        {
            get
            {
                if (IsComplete)
                {
                    return "Complete";
                }
                else
                {
                    return "Incomplete";
                }
            }
        }

        public Task(string taskName, string dueDate, string user)
        {
            TaskName = taskName;
            DueDate = dueDate;
            UserName = user;
        }
    }
}
