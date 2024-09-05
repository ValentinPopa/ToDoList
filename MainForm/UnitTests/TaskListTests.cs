using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect_ToDoList.Classes;
using System;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class TaskListTests
    {
        // Instanțele de TaskList și Task folosite în teste
        private TaskList taskList;
        private Task workTask;

        // Setup-ul care rulează înainte de fiecare test
        // Inițializează lista de sarcini și un obiect WorkTask pentru a fi folosit în teste
        [TestInitialize]
        public void Setup()
        {
            taskList = new TaskList();
            workTask = new WorkTask("Test Task", "Test Description");
        }

        // Testează dacă metoda `AddTask` adaugă corect sarcina în listă
        [TestMethod]
        public void AddTask_ShouldAddTaskToList()
        {
            // Act: Se adaugă sarcina `workTask` în lista de sarcini
            taskList.AddTask(workTask);

            // Assert: Verifică dacă sarcina a fost adăugată corect în listă
            Assert.IsTrue(taskList.GetAllTasks().Contains(workTask), "Task should be added to the list");
        }

        // Testează dacă metoda `RemoveTask` elimină corect sarcina din listă
        [TestMethod]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            // Arrange: Se adaugă mai întâi sarcina pentru a putea fi eliminată
            taskList.AddTask(workTask);

            // Act: Se elimină sarcina `workTask` din lista de sarcini
            taskList.RemoveTask(workTask);

            // Assert: Verifică dacă sarcina a fost eliminată corect din listă
            Assert.IsFalse(taskList.GetAllTasks().Contains(workTask), "Task should be removed from the list");
        }

        // Testează dacă actualizarea stării unei sarcini notifică observatorul
        [TestMethod]
        public void TaskStatusUpdate_ShouldTriggerObserver()
        {
            // Arrange: Variabilă pentru a urmări dacă observatorul a fost notificat
            bool wasUpdated = false;

            // Adaugă sarcina la listă și abonează un observator care schimbă valoarea `wasUpdated` când se declanșează evenimentul
            taskList.AddTask(workTask);
            workTask.TaskUpdated += (task) => wasUpdated = true;

            // Act: Schimbă starea sarcinii prin apelul metodei `Start`, care ar trebui să declanșeze evenimentul TaskUpdated
            workTask.Start(); // This should trigger the TaskUpdated event

            // Assert: Verifică dacă observatorul a fost notificat de actualizarea stării sarcinii
            Assert.IsTrue(wasUpdated, "Observer should be notified of the task status update");
        }
    }
}
