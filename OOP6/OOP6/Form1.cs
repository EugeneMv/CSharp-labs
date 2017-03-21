using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unionStr_Click(object sender, EventArgs e)
        {
            Base.Text = Base.Text.ToString() + SubBox1.Text.ToString();
        }

        private void DelSubStr_Click(object sender, EventArgs e)
        {
            Base.Text = Base.Text.Replace(SubBox1.Text, "");
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            Base.Text = Base.Text.Replace(SubBox1.Text, SubBox2.Text);
        }

        private void FindStr_Click(object sender, EventArgs e)
        {
            try { SubBox2.Text = Base.Text.ToCharArray()[Convert.ToInt16(SubBox1.Text)].ToString(); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void LengthStr_Click(object sender, EventArgs e)
        {
            SubBox2.Text = Base.Text.Length.ToString();
        
}

        private void DoubleStr_Click(object sender, EventArgs e)
        {
            Base.Text = Base.Text.Replace("a", "aa").Replace("e", "ee").Replace("y", "yy").Replace("u", "uu").Replace("i", "ii").Replace("o", "oo");
        }


    }
}
