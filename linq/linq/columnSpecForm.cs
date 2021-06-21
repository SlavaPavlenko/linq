using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq
{
    public partial class columnSpecForm : Form
    {
        columnSpecDelegate d;
        public columnSpecForm()
        {
            InitializeComponent();
        }

        public columnSpecForm(columnSpecDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            d(name_txt.Text, type_comboBox.Text);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
