namespace TodoList
{
    partial class frmToDoList
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
            System.Windows.Forms.Button btnTask;
            this.lbltoDoList = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTasks = new System.Windows.Forms.ListView();
            btnTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltoDoList
            // 
            this.lbltoDoList.AutoSize = true;
            this.lbltoDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoDoList.Location = new System.Drawing.Point(24, 177);
            this.lbltoDoList.Name = "lbltoDoList";
            this.lbltoDoList.Size = new System.Drawing.Size(143, 29);
            this.lbltoDoList.TabIndex = 3;
            this.lbltoDoList.Text = "To-Do List :";
            // 
            // txtTask
            // 
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTask.Location = new System.Drawing.Point(284, 23);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(289, 41);
            this.txtTask.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put Here Your Task : ";
            // 
            // btnTask
            // 
            btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTask.Location = new System.Drawing.Point(284, 83);
            btnTask.Name = "btnTask";
            btnTask.Size = new System.Drawing.Size(289, 28);
            btnTask.TabIndex = 2;
            btnTask.Text = "Save Task";
            btnTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // listViewTasks
            // 
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(173, 200);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(423, 164);
            this.listViewTasks.TabIndex = 4;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 411);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(btnTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lbltoDoList);
            this.Name = "frmToDoList";
            this.Text = "To-Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltoDoList;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTasks;
    }
}

