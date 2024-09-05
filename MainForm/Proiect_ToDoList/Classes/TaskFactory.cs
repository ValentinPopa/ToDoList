using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ToDoList.Classes
{
    //factory design pattern
    //o implementare a interfetei ITaskFactory
    public class TaskFactory : ITaskFactory
    {
        //creeaza fie un task personal, fie unul de munca
        public Task CreateTask(string type, string title, string description)
        {
            switch (type.ToLower())
            {
                case "work":
                    return new WorkTask(title, description);
                case "personal":
                    return new PersonalTask(title, description);
                default:
                    throw new ArgumentException("Invalid task type.");
            }
        }
    }

}
