using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortArray
{
    public partial class Form1 : Form
    {
        public int n;
        public int[] arrea;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
       
        public void Generate()
        {
            arrea = new int[n];
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random random = new Random();
            for(int i = 0; i <n; i++)
            {
                arrea[i] = random.Next(1000);

            }
        }
 
        public void PrintArea()
        {
        
            for (int i = 0; i < n; i++)
            {
                listBox2.Items.Add(arrea[i].ToString());

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                
            }
            n = Convert.ToInt32(checkBox1.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            n = Convert.ToInt32(checkBox2.Text);
        }
   private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
            n = Convert.ToInt32(checkBox3.Text);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            n = Convert.ToInt32(checkBox4.Text);
        }

        BubbleSort bubble;
        SelectionSort selection;
        QuickSort quick;
        private void button1_Click(object sender, EventArgs e)
        {//bubble
            bubble = new BubbleSort();
            Generate();
            PrintArea();
            MessageBox.Show("Массив сгенерирован");
            bubble.Sort(arrea,n);
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(arrea[i].ToString());
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {//quick
           
            Generate();
            PrintArea();
            MessageBox.Show("Массив сгенерирован");
            quick = new QuickSort();
            quick.Sort(arrea, 0,arrea.Length-1);
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(arrea[i].ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//selection
            selection = new SelectionSort();
            Generate();
            PrintArea();
            MessageBox.Show("Массив сгенерирован");
            selection.Sort(arrea, n);
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(arrea[i].ToString());

            }
        }

     

       
    }
}
