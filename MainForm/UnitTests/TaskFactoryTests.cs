using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect_ToDoList.Classes;
using System;

namespace UnitTests
{
    [TestClass]
    public class TaskFactoryTests
    {
        private ITaskFactory factory;

        // Această metodă se execută înainte de fiecare test
        // Inițializează obiectul `factory` cu o instanță de `TaskFactory`
        [TestInitialize]
        public void Setup()
        {
            factory = new TaskFactory();
        }

        // Testează dacă metoda `CreateTask` returnează un `WorkTask` atunci când tipul este "work"
        [TestMethod]
        public void CreateTask_ShouldReturnWorkTask_WhenTypeIsWork()
        {
            // Arrange: Pregătește datele de intrare pentru test
            string type = "work";
            string title = "Work Task";
            string description = "Work Task Description";

            // Act: Apelează metoda `CreateTask` și creează o sarcină de tip work
            var task = factory.CreateTask(type, title, description);

            // Assert: Verifică dacă task-ul este de tip `WorkTask`
            // Verifică, de asemenea, dacă titlul și descrierea au fost setate corect
            Assert.IsInstanceOfType(task, typeof(WorkTask), "Task should be of type WorkTask");
            Assert.AreEqual(title, task.Title, "Title should match");
            Assert.AreEqual(description, task.Description, "Description should match");
        }

        // Testează dacă metoda `CreateTask` returnează un `PersonalTask` atunci când tipul este "personal"
        [TestMethod]
        public void CreateTask_ShouldReturnPersonalTask_WhenTypeIsPersonal()
        {
            // Arrange: Pregătește datele de intrare pentru test
            string type = "personal";
            string title = "Personal Task";
            string description = "Personal Task Description";

            // Act: Apelează metoda `CreateTask` și creează o sarcină de tip personal
            var task = factory.CreateTask(type, title, description);

            // Assert: Verifică dacă task-ul este de tip `PersonalTask`
            // Verifică, de asemenea, dacă titlul și descrierea au fost setate corect
            Assert.IsInstanceOfType(task, typeof(PersonalTask), "Task should be of type PersonalTask");
            Assert.AreEqual(title, task.Title, "Title should match");
            Assert.AreEqual(description, task.Description, "Description should match");
        }

        // Testează dacă metoda `CreateTask` aruncă o excepție atunci când tipul este invalid
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTask_ShouldThrowException_WhenTypeIsInvalid()
        {
            // Arrange: Pregătește datele de intrare pentru un task cu un tip invalid
            string type = "invalid";
            string title = "Invalid Task";
            string description = "Invalid Task Description";

            // Act: Apelează metoda `CreateTask` cu un tip invalid
            // Se așteaptă să fie aruncată o excepție `ArgumentException`
            factory.CreateTask(type, title, description);

            // Assert: Nu este necesar aici deoarece `[ExpectedException]` specifică că testul va trece
            // dacă o excepție de tipul așteptat este aruncată.
        }
    }
}
