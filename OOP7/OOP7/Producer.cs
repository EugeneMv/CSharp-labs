using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP7
{
    public partial class Producer : Form
    {
        string str = "";

        public Producer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                textBox4.Text != "")
            {
                Transfer.Name = textBox1.Text;
                Transfer.Country = textBox1.Text;
                Transfer.Adress = textBox3.Text;
                Transfer.Phone = textBox4.Text;
                Close();
            }
            else label10.Text = "Заполнены не все поля";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void Producer_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 7;
            label10.Text = "";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }
    }
}
