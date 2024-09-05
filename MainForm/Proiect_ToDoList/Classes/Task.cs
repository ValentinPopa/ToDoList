using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ToDoList.Classes
{
    //clasa pentru toate sarcinile din aplicatie
    public abstract class Task
    {
        public string Title { get; set; } //titlul task ului
        public string Description { get; set; } //descrierea task ului
        public string Status { get; private set; } //status ul task ului

        public event Action<Task> TaskUpdated; //eveniment declansat de fiecare data cand status ul este schimbat

        public Task(string title, string description)
        {
            Title = title;
            Description = description;
            Status = "Not Started";
        }

        public void Start()
        {
            Status = "In Progress";
            Notify();
        }
        //metoda interna care declanseaza evenimentul taskupdated
        public void Complete()
        {
            Status = "Completed";
            Notify();
        }

        protected void Notify()
        {
            TaskUpdated?.Invoke(this);
        }
        //suprascriere metoda tostring
        public override string ToString()
        {
            return $"{Title} - {Status}";
        }
    }

}
