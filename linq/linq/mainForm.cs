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
        public static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
        addTableForm addTableForm;
        public delegate void addTableDelegate(string name, ObjectCollection collection);
        deleteTableForm deleteTableForm;
        public delegate void deleteTableDelegate(string name);
        editTableForm editTableForm;
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
            cmd.ExecuteNonQuery();
        }

        private void deleteTable_btn_Click(object sender, EventArgs e)
        {
            deleteTableForm = new deleteTableForm(new deleteTableDelegate(deleteTable));
            deleteTableForm.Show();
        }
        private void deleteTable(string name)
        {
            string command = "drop table " + name;
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            try {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void editTable_btn_Click(object sender, EventArgs e)
        {
            editTableForm = new editTableForm();
            editTableForm.Show();
        }
    }
}
