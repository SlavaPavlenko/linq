using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static linq.mainForm;

namespace linq
{
    public partial class deleteTableForm : Form
    {
        deleteTableDelegate d;
        public deleteTableForm()
        {
            InitializeComponent();
        }
        public deleteTableForm(deleteTableDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (name_comboBox.Text.Trim() != "")
                d(name_comboBox.Text);
            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteTableForm_Load(object sender, EventArgs e)
        {
            name_comboBox.Items.Clear();

            string command = "select * from INFORMATION_SCHEMA.TABLES";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name_comboBox.Items.Add(reader.GetString(reader.GetOrdinal("table_name")));
            }
            reader.Close();
        }
    }
}
