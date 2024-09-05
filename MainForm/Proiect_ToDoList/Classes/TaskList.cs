using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ToDoList.Classes
{
    //observer design pattern
    //gestionarea unei liste de sarcini
    public class TaskList
    {
        private List<Task> tasks = new List<Task>(); //lista de obiecte tasks
        //adaugare task
        public void AddTask(Task task)
        {
            tasks.Add(task);
            task.TaskUpdated += UpdateTaskList;
        }
        //stergere task
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
            task.TaskUpdated -= UpdateTaskList;
        }
        //updatare status task
        private void UpdateTaskList(Task task)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.UpdateTaskListDisplay();
        }
        //returneaza toate sarcinile din lista
        public IEnumerable<Task> GetAllTasks()
        {
            return tasks;
        }
    }


}
