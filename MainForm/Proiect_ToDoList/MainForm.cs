using Proiect_ToDoList.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_ToDoList
{
    public partial class MainForm : Form
    {
        private TaskList taskList = new Classes.TaskList();
        private ITaskFactory taskFactory = new Classes.TaskFactory();
        public MainForm()
        {
            InitializeComponent();
            cbTaskType.Items.Add("Work");
            cbTaskType.Items.Add("Personal");
            cbTaskType.SelectedIndex = 0; // Selectează primul element ca implicit
        }

        public void UpdateTaskListDisplay()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in taskList.GetAllTasks())
            {
                // Adaugă obiectul Task în ListBox
                listBoxTasks.Items.Add(task);
            }
        }

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            // Gather data from input fields
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string type = cbTaskType.SelectedItem.ToString();

            // Create a new task using the factory
            Classes.Task newTask = taskFactory.CreateTask(type, title, description);

            // Add the task to the list and update UI
            taskList.AddTask(newTask);
            UpdateTaskListDisplay();
        }

        private void btnStartTask_Click_1(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem is Classes.Task selectedTask)
            {
                selectedTask.Start();
                UpdateTaskListDisplay();
            }
        }

        private void btnCompleteTask_Click_1(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem is Classes.Task selectedTask)
            {
                selectedTask.Complete();
                UpdateTaskListDisplay();
            }
        }
    } 
}
