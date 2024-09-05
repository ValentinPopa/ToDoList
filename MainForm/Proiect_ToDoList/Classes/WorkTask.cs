using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ToDoList.Classes
{
    //clasa derivata din task care reprezinta sarcinile de la munca
    public class WorkTask : Task
    {
        //apelul constructorului parintilor pentru a seta titlul si descrierea unei sarcini de la munca
        public WorkTask(string title, string description)
            : base(title, description)
        {
        }
    }

}
