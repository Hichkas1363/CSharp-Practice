System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "مرتب سازی";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int[] arr = { 12, 5, 18, 6, 84, 7 };

            SelectionSort(arr);

            listBox1.Items.Clear();

            foreach (int x in arr)
            {
                listBox1.Items.Add(x);
            } } } }
