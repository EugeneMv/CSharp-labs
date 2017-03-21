using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP7
{
    public partial class Form1 : Form
    {
        Producer p = new Producer();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text != ""&&txt2.Text != ""&&txt3.Text != ""&&
                textBox1.Text != ""&& comboBox1.Text != ""&& 
                comboBox2.Text != "") {
                SaveInf Q = new SaveInf(txt1.Text, Convert.ToInt16(txt2.Text), Convert.ToSingle(txt3.Text),
                    Convert.ToSingle(textBox1.Text), dateTimePicker1.Text, comboBox1.Text,
                    Convert.ToInt16(numericUpDown1.Value), comboBox2.Text);
                Q.Save();
                listBox1.Items.Clear();
                listBox1.Items.Add(Q);
            }
            else label10.Text = "Заполнены не все поля!";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.StartPosition = FormStartPosition.CenterParent;
            p.ResetText();
            p.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            txt3.MaxLength = 4;
            label10.Text = "";
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') &&
                (((TextBox)sender).Text.IndexOf(".") == -1) &&
                (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(Transfer.Name!="")
            comboBox2.Items.Add(Transfer.Name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
            textBox1.MaxLength = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveInf Q = new SaveInf();
            Q.Load();
            txt1.Text = Q.name;
            txt2.Text = Q.number.ToString();
            txt3.Text = ((float)Q.size).ToString();
            textBox1.Text = Q.weight.ToString();
            dateTimePicker1.Text = Q.date;
            comboBox1.Text = Q.type;
            numericUpDown1.Value = Q.count;
            comboBox2.Text = Q.producer;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            label10.Text = "";
            txt2.MaxLength = 4;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') &&
               (((TextBox)sender).Text.IndexOf(".") == -1) &&
               (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
