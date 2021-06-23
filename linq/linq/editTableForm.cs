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
    public partial class editTableForm : Form
    {
        public editTableForm()
        {
            InitializeComponent();
        }

        private void editTableForm_Load(object sender, EventArgs e)
        {
            name_comboBox.Items.Clear();

            string command = "select * from INFORMATION_SCHEMA.TABLES";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name_comboBox.Items.Add(reader.GetString(reader.GetOrdinal("table_name")));
                //var a = reader.GetSchemaTable();
            }
            reader.Close();
        }

        private void name_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            table_dataGridView.Rows.Clear();
            table_dataGridView.Columns.Clear();

            //количество столбцов
            string command = "SELECT COUNT(*) as 'count' FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + name_comboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int columnAmount = reader.GetInt32(reader.GetOrdinal("count"));
            reader.Close();

            //имена столбцов
            command = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + name_comboBox.Text + "'";
            cmd.CommandText = command;
            reader = cmd.ExecuteReader();
            string[] columnNames = new string[columnAmount];
            for (int i = 0; i < columnAmount; i++) {
                reader.Read();
                columnNames[i] = reader[0].ToString();
            }
            foreach (string item in columnNames)
            {
                table_dataGridView.Columns.Add(item, item);
            }
            reader.Close();

            //данные
            command = "select * from " + name_comboBox.Text;
            cmd.CommandText = command;
            reader = cmd.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[columnAmount]);

                for (int i = 0; i < columnAmount; i++) {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }

            foreach (string[] item in data)
            {
                table_dataGridView.Rows.Add(item);
            }
            reader.Close();
        }

        private void linq_btn_Click(object sender, EventArgs e)
        {
            if (table_dataGridView.Columns.Count > 0 && table_dataGridView.Rows.Count > 1)
            {
                var IDs = table_dataGridView.Rows.Cast<DataGridViewRow>();
                //элемент с id = 11
                var linq1 = IDs.Where(id => Convert.ToInt32(id.Cells[0].Value) == 11);
                //количество элементов с нечетным id
                var linq2 = IDs.Count(id => Convert.ToInt32(id.Cells[0].Value) % 2 == 1);
                //id последнего четного элемента
                var linq3 = IDs.Last(id => Convert.ToInt32(id.Cells[0].Value) % 2 == 1);

                //вывод
                var message = "Элемент с id = 11 ";
                if (linq1.ToArray().Length > 0)
                    message += "обнаружен;\n";
                else
                    message += "не обнаружен;\n";
                message += "Элементов с нечетным id: " + linq2.ToString() + ";\n";
                message += "Последний нечетный id элемента: " + linq3.Cells[0].Value + ";";
                MessageBox.Show(message);
            } else
                MessageBox.Show("Таблица не выбрана или пуста");
        }
    }
}
