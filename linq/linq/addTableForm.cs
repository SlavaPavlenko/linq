using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static linq.mainForm;

namespace linq
{
    public delegate void columnSpecDelegate(string name, string type);

    public partial class addTableForm : Form
    {
        columnSpecForm columnSpecForm;
        addTableDelegate d;
        public addTableForm()
        {
            InitializeComponent();
        }
        public addTableForm(addTableDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            d(name_txt.Text, columns_listBox.Items);
            Close();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            columnSpecForm = new columnSpecForm(new columnSpecDelegate(columnAdd));
            columnSpecForm.Show();
        }

        void columnAdd(string name, string type) {
            columns_listBox.Items.Add(name + "-" + type);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            columns_listBox.Items.Remove(columns_listBox.SelectedItem);
        }
    }
}
