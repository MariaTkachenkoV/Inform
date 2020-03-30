using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleInf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Text = "ФИО";
            listView1.Columns[1].Text = "Номер зачетки";
            listView1.Columns[2].Text = "Курс";
            listView1.Items.Add("Ткаченко М.");
            listView1.Items[0].SubItems.Add("000000000");
            listView1.Items[0].SubItems.Add("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listView1.SelectedItems.Count - 1;
            if (listView1.SelectedIndices.Count != 0)
            {
                MessageBox.Show(listView1.SelectedItems[i].Text + " №" + listView1.SelectedItems[i].SubItems[i + 1].Text + " " + listView1.SelectedItems[i].SubItems[i + 2].Text + " курс");
            }
            else
            {
                MessageBox.Show("Выберите из списка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.Owner = this;
            add.ShowDialog();
            if (add.textBox1.Text != null && add.textBox2.Text != null && add.comboBox1.Text != null)
            {
                int i = listView1.Items.Count;
                listView1.Items.Add(add.textBox1.Text);
                listView1.Items[i].SubItems.Add(add.textBox2.Text);
                listView1.Items[i].SubItems.Add(add.comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Вы ничего не ввели");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.Owner = this;
            add.ShowDialog();
            if (add.textBox1.Text != null && add.textBox2.Text != null && add.comboBox1.Text != null)
            {
                int j = listView1.SelectedIndices.Count-1;
                listView1.Items[j+1].Text = add.textBox1.Text;
                listView1.Items[j+1].SubItems[j + 1].Text = add.textBox2.Text;
                listView1.Items[j+1].SubItems[j + 2].Text = add.comboBox1.Text;
            }
            else
            {
                MessageBox.Show("Вы ничего не ввели");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[listView1.SelectedIndices.Count - 1]);
            }
            else
            {
                MessageBox.Show("Что ты делаешь ?");
            }
        }
    }
}

