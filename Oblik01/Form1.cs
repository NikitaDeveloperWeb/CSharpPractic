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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.accountDataSet.Account);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.accountDataSet.Worker);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            accountBindingSource.Filter = "ID_Worker = " + id.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // создать фильтр, который выведет в dataGridView2 то что нужно
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            // взять значения id = Worker.ID_Worker
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            accountBindingSource.Filter = "ID_Worker = " + id.ToString();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddWorker f = new FormAddWorker(); // создать форму

            if (f.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                // если OK, то добавить работника
                string WName, WPosition, WSex;

                WName = f.textBox1.Text;
                WPosition = f.textBox2.Text;
                WSex = f.comboBox1.Items[f.comboBox1.SelectedIndex].ToString();

                // работает
                this.workerTableAdapter.Insert(WName, WPosition, WSex); // вставка
                this.workerTableAdapter.Fill(this.accountDataSet.Worker); // отображение
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Worker => Delete
            FormDelWorker f = new FormDelWorker(); // создать форму
            int id_worker;
            string WName, WPosition, WSex;
            int index;

            // взять номер текущей (выделенной) строки в dataGridView1
            index = dataGridView1.CurrentRow.Index;

            // заполнить внутренние переменные из текущей строки dataGridView1
            id_worker = Convert.ToInt32(dataGridView1[0, index].Value);
            WName = Convert.ToString(dataGridView1[1, index].Value);
            WPosition = Convert.ToString(dataGridView1[2, index].Value);
            WSex = Convert.ToString(dataGridView1[3, index].Value);

            // сформировать информационную строку
            f.label2.Text = WName + " " + WPosition;

            if (f.ShowDialog() == DialogResult.OK)
            {
                workerTableAdapter.Delete(id_worker, WName, WPosition, WSex); // метод Delete
                this.workerTableAdapter.Fill(this.accountDataSet.Worker);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Worker => Edit...
            FormEditWorker f = new FormEditWorker(); // создать форму

            int index;
            string WName, WPosition, WSex;
            int id_worker;

            if (dataGridView1.RowCount <= 1) return;

            // получить позицию выделенной строки в dataGridView1
            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return; //

            // получить данные строки
            id_worker = (int)dataGridView1.Rows[index].Cells[0].Value;
            WName = (string)dataGridView1.Rows[index].Cells[1].Value;
            WPosition = (string)dataGridView1.Rows[index].Cells[2].Value;
            WSex = (string)dataGridView1.Rows[index].Cells[3].Value;

            // заполнить поля формы f
            f.textBox1.Text = WName;
            f.textBox2.Text = WPosition;

            if (WSex == "M") f.comboBox1.SelectedIndex = 0;
            else f.comboBox1.SelectedIndex = 1;

            if (f.ShowDialog() == DialogResult.OK) // вызвать форму FormEditWorker
            {
                string nWName, nWPosition, nWSex;

                // получить новые (измененные) значения из формы
                nWName = f.textBox1.Text;
                nWPosition = f.textBox2.Text;
                nWSex = f.comboBox1.Items[f.comboBox1.SelectedIndex].ToString();

                // сделать изменения в адаптере
                this.workerTableAdapter.Update(nWName, nWPosition, nWSex, id_worker, WName, WPosition, WSex);
                this.workerTableAdapter.Fill(this.accountDataSet.Worker);
            }
        }


        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Inventory => Add...
            AddAccount f = new AddAccount(); // окно

            if (f.ShowDialog() == DialogResult.OK)
            {
                int Id_Worker;
                int index;
                string ANum, ADate, AInvNum, AObjName;
                short ACount;
                double APrice;

                // взять значения ID_Worker из таблицы Worker
                index = dataGridView1.CurrentRow.Index; // позиция в dataGridView1
                Id_Worker = (int)dataGridView1.Rows[index].Cells[0].Value;

                // взять значения других полей из формы FormAddAccount
                ANum = f.textBox1.Text;
                ADate = f.textBox2.Text;
                AInvNum = f.textBox3.Text;
                AObjName = f.textBox4.Text;
                ACount = Convert.ToInt16(f.textBox5.Text);
                APrice = Convert.ToDouble(f.textBox6.Text);

                this.accountTableAdapter.Insert(Id_Worker, ANum, ADate, AInvNum, AObjName, ACount, APrice);
                this.accountTableAdapter.Fill(this.accountDataSet.Account);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Inventory => Delete
            FormDelAccount f = new FormDelAccount();
            int id_account, id_worker;
            string ANum, ADate, AInvNum, AObjName;
            short ACount;
            double APrice;
            int index;

            // взять индекс выделенной (текущей) строки в dataGridView2
            index = dataGridView2.CurrentRow.Index;

            // взять значения полей строки с номером index
            id_account = Convert.ToInt32(dataGridView2[0, index].Value);
            id_worker = Convert.ToInt32(dataGridView2[1, index].Value);
            ANum = Convert.ToString(dataGridView2[2, index].Value);
            ADate = Convert.ToString(dataGridView2[3, index].Value);
            AInvNum = Convert.ToString(dataGridView2[4, index].Value);
            AObjName = Convert.ToString(dataGridView2[5, index].Value);
            ACount = Convert.ToInt16(dataGridView2[6, index].Value);
            APrice = Convert.ToDouble(dataGridView2[7, index].Value);

            // сформировать информационную строку в окне FormDelAccount
            f.label2.Text = ANum + " / " + ADate + " / " + AInvNum + " / " +
                AObjName + " / " + ACount + " / " + APrice;

            if (f.ShowDialog() == DialogResult.OK) // вывести окно
            {
                this.accountTableAdapter.Delete(id_account, id_worker,
                    ANum, ADate, AInvNum, AObjName, ACount, APrice); // удалить строку
                this.accountTableAdapter.Fill(this.accountDataSet.Account); // зафиксировать изменения
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Inventory => Edit...
            FormEditAccount f = new FormEditAccount();

            int index;
            int id_account;
            int id_worker;
            string ANum, ADate, AInvNum, AObjName;
            short ACount;
            double APrice;

            if (dataGridView2.RowCount <= 1) return;

            // взять номер текущей строки в dataGridView2
            index = dataGridView2.CurrentRow.Index;

            if (index == dataGridView2.RowCount - 1) return; //

            // получить данные строки
            id_account = (int)dataGridView2.Rows[index].Cells[0].Value;
            id_worker = (int)dataGridView2.Rows[index].Cells[1].Value;
            ANum = (string)dataGridView2.Rows[index].Cells[2].Value;
            ADate = (string)dataGridView2.Rows[index].Cells[3].Value;
            AInvNum = (string)dataGridView2.Rows[index].Cells[4].Value;
            AObjName = (string)dataGridView2.Rows[index].Cells[5].Value;
            ACount = (short)dataGridView2.Rows[index].Cells[6].Value;
            APrice = (double)dataGridView2.Rows[index].Cells[7].Value;

            // заполнить данными строку в FormEditAccount
            f.textBox1.Text = ANum;
            f.textBox2.Text = ADate;
            f.textBox3.Text = AInvNum;
            f.textBox4.Text = AObjName;
            f.textBox5.Text = Convert.ToString(ACount);
            f.textBox6.Text = Convert.ToString(APrice);

            // заполнить поля формы FormEditAccount
            if (f.ShowDialog() == DialogResult.OK) // вызвать форму
            {
                // новые значения строки
                string nANum, nADate, nAInvNum, nAObjName;
                short nACount;
                double nAPrice;

                // взять новые значения
                nANum = f.textBox1.Text;
                nADate = f.textBox2.Text;
                nAInvNum = f.textBox3.Text;
                nAObjName = f.textBox4.Text;
                nACount = Convert.ToInt16(f.textBox5.Text);
                nAPrice = Convert.ToDouble(f.textBox6.Text);

                // обновить данные в строке
                this.accountTableAdapter.Update(id_worker, nANum, nADate, nAInvNum, nAObjName, nACount, nAPrice,
                id_account, id_worker, ANum, ADate, AInvNum, AObjName, ACount, APrice);
                this.accountTableAdapter.Fill(this.accountDataSet.Account);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            workerBindingSource.Filter = "WName LIKE '" + textBox1.Text + "%'";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
