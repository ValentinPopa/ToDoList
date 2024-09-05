namespace Proiect_ToDoList
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbTaskType = new System.Windows.Forms.ComboBox();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(120, 310);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click_1);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Location = new System.Drawing.Point(331, 310);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(75, 23);
            this.btnStartTask.TabIndex = 8;
            this.btnStartTask.Text = "Start";
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click_1);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Location = new System.Drawing.Point(544, 310);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteTask.TabIndex = 7;
            this.btnCompleteTask.Text = "Complete";
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click_1);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 142);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 210);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // cbTaskType
            // 
            this.cbTaskType.FormattingEnabled = true;
            this.cbTaskType.Location = new System.Drawing.Point(120, 67);
            this.cbTaskType.Name = "cbTaskType";
            this.cbTaskType.Size = new System.Drawing.Size(121, 21);
            this.cbTaskType.TabIndex = 5;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(469, 41);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(252, 173);
            this.listBoxTasks.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.cbTaskType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.btnStartTask);
            this.Controls.Add(this.btnAddTask);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbTaskType;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

