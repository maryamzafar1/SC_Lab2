using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SoftwareConstructionLab2
{
    //struct session { public static string usernm, passw; }
    
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Maryam\Documents\Visual Studio 2017\Projects\AppData.accdb");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                //OleDbDataAdapter da = new OleDbDataAdapter("SELECT username, password FROM User where username='" + username.Text + "'and password='" + password.Text + "'", conn);
                AppDataSetTableAdapters.UserTableAdapter user = new AppDataSetTableAdapters.UserTableAdapter();
                AppDataSet.UserDataTable dt = user.GetDataByUsernameandPassword(username.Text, password.Text);
                //da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Main main = new Main(username.Text,password.Text);
                    main.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void signup_Click(object sender, EventArgs e)
        {
            try
            {

                //AppDataTableAdapters.UserTableAdapter user = new AppDataTableAdapters.UserTableAdapter();
                //user.InsertUsernameandPassword(textBox2.Text, textBox1.Text);
                //this.appData.User.AddUserRow(this.appData.User.NewUserRow());
                //userBindingSource.MoveLast();
                //userBindingSource.EndEdit();
                //userTableAdapter.Update(this.appData.User);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [user](username)values(@usern)";
                //cmd.Parameters.AddWithValue("@id", 4);
                cmd.Parameters.AddWithValue("@usern", username.Text);
                //cmd.Parameters.AddWithValue("@pass", password.Text);
                cmd.Connection = conn;
                int a= cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Inserted");
                }
                //MessageBox.Show("Record Submitted", "Congrats");
                conn.Close();

                this.Hide();
                Main main = new Main(username.Text, password.Text);
                main.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
