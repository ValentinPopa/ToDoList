using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_ToDoList.Classes
{
    //clasa derivata din task care reprezinta sarcinile personale
    public class PersonalTask : Task
    {
        //apelul constructorului parintilor pentru a seta titlul si descrierea unei sarcini personale
        public PersonalTask(string title, string description)
            : base(title, description)
        {
        }
    }

}
