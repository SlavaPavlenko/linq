using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.ListBox;

namespace linq
{
    public partial class mainForm : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        addTableForm addTableForm;
        public delegate void addTableDelegate(string name, ObjectCollection collection);
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (sqlConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Подключение не установлено");
            }
        }

        private void createTable_btn_Click(object sender, EventArgs e)
        {
            addTableForm = new addTableForm(new addTableDelegate(addTable));
            addTableForm.Show();
        }

        private void addTable(string name, ObjectCollection collection) {
            string command = "create table " + name + "(id int identity(1,1) primary key";
            if (collection.Count > 0)
            {
                foreach (string item in collection)
                {
                    String[] s = item.Split('-');
                    command += ", " + s[0] + " " + s[1];
                }
            }
            command += ")";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            var a = cmd.ExecuteNonQuery();
        }
    }
}
