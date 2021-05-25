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
    public partial class Login : Form
    {
        public static Administrator administrator = new Administrator();
        public static User user = new User();
        private DBAccess objDbAccess = new DBAccess();
        private DataTable dtUsers = new DataTable();
            
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            user.Username = userNameTxt.Text;
            user.Password = passwordTxt.Text;
            if (user.Username.Equals("")) MessageBox.Show("Please enter your Username");
            else if (user.Password.Equals("")) MessageBox.Show("Please enter your Password");
            else
            {
                string query = "SELECT username, password FROM users_table WHERE username='" + user.Username + "' AND password = '" + user.Password + "'";

                objDbAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO login_history_table(username, login_date) VALUES (@username, @login_date);");
                    insertCommand.Parameters.AddWithValue("@username", user.Username);
                    insertCommand.Parameters.AddWithValue("@login_date", DateTime.Now.ToString("yyyy-MM-dd"));
                    objDbAccess.executeQuery(insertCommand);

                    OpenMain();
                    objDbAccess.closeConn();
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password");
                }
            }
        }

        private void OpenMain()
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            user.Username = userNameTxt.Text;
            user.Password = passwordTxt.Text;
            if (user.Username.Equals("")) MessageBox.Show("Please enter your Username");
            else if (user.Password.Equals("")) MessageBox.Show("Please enter your Password");
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into users_table(username, password) values (@userUsername, @userPassword)");

                insertCommand.Parameters.AddWithValue("@userUsername", user.Username);
                insertCommand.Parameters.AddWithValue("@userPassword", user.Password);

                int row = objDbAccess.executeQuery(insertCommand);
                if(row == 1)
                {
                    MessageBox.Show("Account Created Successfully");
                    OpenMain();
                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again");
                }
            }
        }
    }
}
