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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int j = 1; j < 6; j++)
            {
                comboBox1.Items.Add(j);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = Owner as Form1;
            if (main.button3.Enabled)
            {
                Close();
            }
            if(main.button2.Enabled)
            {
                Close();
            }
        }
    }
}
