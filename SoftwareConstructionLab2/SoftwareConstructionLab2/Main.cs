﻿using System;
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
    public partial class Main : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Maryam\Documents\Visual Studio 2017\Projects\AppData.accdb");
        public Main(string usernm, string passw)
        {
            InitializeComponent();
            user_session.Text = usernm;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataSet.Journals' table. You can move, or remove it, as needed.
            this.journalsTableAdapter.Fill(this.appDataSet.Journals);
            // TODO: This line of code loads data into the 'appDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.appDataSet.Books);
            //user_session.Text = session.usernm;
            //MessageBox.Show(session.usernm);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            //int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value.ToString());
            string id = dataGridView1["BookID", e.RowIndex].Value.ToString();
            //MessageBox.Show(id);
            DateTime today = DateTime.Today;
            cmd.CommandType = CommandType.Text;
           /* cmd.CommandText = "insert into [issue](user, bookid,issuedate,fine) VALUES (@usr,@bookid,@issuedate,@fine)";
            cmd.Parameters.AddWithValue("@usr", user_session.Text);
            cmd.Parameters.AddWithValue("@bookid", id);
            cmd.Parameters.AddWithValue("@issuedate",today);
            cmd.Parameters.AddWithValue("@fine",0);
            cmd.Connection = conn;*/
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("The Book has been issued!");
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            //int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value.ToString());
            string id = dataGridView1["ArticleID", e.RowIndex].Value.ToString();
            //MessageBox.Show(id);
            DateTime today = DateTime.Today;
            cmd.CommandType = CommandType.Text;
            /* cmd.CommandText = "insert into [issue](user, bookid,issuedate,fine) VALUES (@usr,@bookid,@issuedate,@fine)";
             cmd.Parameters.AddWithValue("@usr", Form1.usernm);
             cmd.Parameters.AddWithValue("@bookid", id);
             cmd.Parameters.AddWithValue("@issuedate",today);
             cmd.Parameters.AddWithValue("@fine",0);
             cmd.Connection = conn;
             int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("The Book has been issued!");
            }
             */
        }
    }
}