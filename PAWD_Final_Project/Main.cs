using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PAWD_Final_Project
{
    public partial class Main : Form
    {
        private DBAccess objDbAccess = new DBAccess();
        private DataTable dtUsers = new DataTable();
        private DataTable dtProjects = new DataTable();

        public Main()
        {
            InitializeComponent();
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
            OpenChart();
        }

        private void OpenChart()
        {
            Chart chart = new Chart();
            chart.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //User UI data
            string query = "SELECT * FROM users_table WHERE username='" + Login.user.Username + "' AND password = '" + Login.user.Password + "'";
            objDbAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count == 1)
            {
                userNameLabel.Text = Login.user.Username;
                projectsCountLabel.Text = "Projects: " + dtUsers.Rows[0]["projects_count"].ToString();
                objDbAccess.closeConn();
            }

            //Projects List
            string query1 = "SELECT * FROM projects_table WHERE student_id=" + dtUsers.Rows[0]["id"].ToString();
            objDbAccess.readDatathroughAdapter(query1, dtProjects);
            projectsGridView.DataSource = dtProjects;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Login.administrator.Projects_Count++;
            //Projects Data Table Clear
            dtProjects.Rows.Clear();

            //Input data
            SqlCommand insertCommand = new SqlCommand("insert into projects_table(title, deadline, reminder, creation_date, completed, student_id) values (@title, @deadline, @reminder, @creation_date, @completed, @student_id)");
            insertCommand.Parameters.AddWithValue("@title", nameTxt.Text);
            insertCommand.Parameters.AddWithValue("@deadline", deadlineTime.Value.ToString("yyyy-MM-dd"));
            insertCommand.Parameters.AddWithValue("@reminder", deadlineTime.Value.ToString("yyyy-MM-dd"));
            insertCommand.Parameters.AddWithValue("@creation_date", DateTime.Now.ToString("yyyy-MM-dd"));


            //Defaults data
            insertCommand.Parameters.AddWithValue("@completed", false);
            insertCommand.Parameters.AddWithValue("@student_id", dtUsers.Rows[0]["id"]);
            objDbAccess.executeQuery(insertCommand);

            //Show
            string query1 = "SELECT * FROM projects_table WHERE student_id=" + dtUsers.Rows[0]["id"].ToString();
            objDbAccess.readDatathroughAdapter(query1, dtProjects);
            projectsGridView.DataSource = dtProjects;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Login.administrator.Projects_Count--;
            Int32 cellValue;
            Int32 selectedRowCount = projectsGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            try
            { 

                Int32 selectedRow = projectsGridView.SelectedRows[0].Index;
                cellValue = (Int32)projectsGridView.Rows[selectedRow].Cells["id"].Value;

                string query1 = "DELETE FROM projects_table WHERE id= " + cellValue;

                //Projects Data Table Clear
                dtProjects.Rows.Clear();

                objDbAccess.readDatathroughAdapter(query1, dtProjects);
            }
            catch { }
            
            //Projects List
            string query2 = "SELECT * FROM projects_table WHERE student_id=" + dtUsers.Rows[0]["id"].ToString();
            objDbAccess.readDatathroughAdapter(query2, dtProjects);
            projectsGridView.DataSource = dtProjects;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeLabel();

            //Projects Count
            SqlCommand insertCommand = new SqlCommand("UPDATE users_table SET projects_count= '" + dtProjects.Rows.Count + "' WHERE id= @student_id");
            insertCommand.Parameters.AddWithValue("@student_id", dtUsers.Rows[0]["id"].ToString());
            objDbAccess.executeQuery(insertCommand);

            Login.user.Projects_Count = (int)dtUsers.Rows[0]["projects_count"];
        }

        private void ChangeLabel()
        {
            //Projects Data Table Clear
            dtUsers.Rows.Clear();

            //User UI data
            string query = "SELECT * FROM users_table WHERE username='" + Login.user.Username + "'";
            objDbAccess.readDatathroughAdapter(query, dtUsers);

            //Update Projects Count in label
            projectsCountLabel.Text = "Projects: " + dtUsers.Rows[0]["projects_count"].ToString();
        }
    }
}
