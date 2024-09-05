using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ToDoList.Classes
{
    //aceasta este o interfata care defineste o metoda de fabrica pentru a crea obiecte de tip task
    public interface ITaskFactory
    {
        Task CreateTask(string type, string title, string description);
        //creeaza si returneaza o instanta a unei sarcini pe baza tipului type
    }
}
