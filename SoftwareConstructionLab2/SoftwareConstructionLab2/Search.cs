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
    public partial class Search : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Maryam\Documents\Visual Studio 2017\Projects\AppData.accdb");
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        Main mn = new Main();
        public Search(Main m)
        {
            InitializeComponent();
            Main mn = m;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "author like '%" + textBox1.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "artiname like '%" + textBox2.Text + "%'";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "genre like '%" + textBox3.Text + "%'";

        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getArtifactsDt();
        }
        private DataTable getArtifactsDt()
        {

            using (OleDbCommand cmd = new OleDbCommand("select * from Artifact", conn))
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
            }

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mn.Show();
        }
    }
}
