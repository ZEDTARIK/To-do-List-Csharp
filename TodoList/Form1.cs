using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TodoList
{
    public partial class frmToDoList : Form
    {
        private SqlConnection connection;

        public frmToDoList()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=Zouhair\\SQLEXPRESS;Initial Catalog=Tasks;Integrated Security=True; MultipleActiveResultSets=true;");
            
            try { 
                connection.Open(); 
                //CreateTaskTable();
                LoadTasks();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }    

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            string name = txtTask.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                string sql = "INSERT INTO tasks (name) VALUES (@name)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                txtTask.Text = "";
                LoadTasks();
            }
        }

        private void CreateTaskTable()
        {
            string sql = "CREATE TABLE dbo.tasks (id INT IDENTITY PRIMARY KEY, name NVARCHAR(100) NOT NULL, completed BIT NOT NULL DEFAULT 0)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
        }

        private void LoadTasks()
        {
            listViewTasks.Items.Clear();
            string sql = "SELECT * FROM tasks";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                bool completed = reader.GetBoolean(2);
                ListViewItem item = new ListViewItem(name);
                item.Tag = id;
                item.Checked = completed;
                listViewTasks.Items.Add(item);
            }
        }

    

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                int id = (int)listViewTasks.SelectedItems[0].Tag;
                string sql = "DELETE FROM tasks WHERE id = @id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                LoadTasks();
            }
        }

        private void listViewTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int id = (int)e.Item.Tag;
            bool completed = e.Item.Checked;
            string sql = "UPDATE tasks SET completed = @completed WHERE id = @id";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@completed", completed);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }


    }
}
