using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oblik01
{
    public partial class FormAddWorker : Form
    {
        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 1;
            textBox1.Focus(); // при открытии окна, textBox1 получает фокус
        }
    }
}
