using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Star(int number)
        {

            string result = "";

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += "*";
                }
                result += Environment.NewLine;
            }
            return result;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "عدد";
            label2.Text = "نمایش مثلث ها";
            button1.Text = "اجرا";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("لطفا یک عدد وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                int number = int.Parse(textBox1.Text);
                textBox2.Text = Star(number);

            }
        }
    }
