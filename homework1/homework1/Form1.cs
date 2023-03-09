using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        
        private List<int> numberarray = new List<int>();
        // private List<int> primes = new List<int>();
        private int lowBoundary;
        private int upBoundary;
        private int times; // 计算次数,多于一次就不再向numberarray中增加元素

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string[] numbers = arrayInput.Text.Split(' ', ',');
            foreach(string s in numbers)
            {
                string ss = s.Trim();
                numberarray.Add(int.Parse(ss));   
            }*/
            // 这里如果这样写，实际上是一边输入一边添加到list里，在输入的时候不应该有任何处理
        }


        // 控件点击后处理
        private void ConvertStringToArray()
        {
            if (times == 0)
            {
                string[] numbers = arrayInput.Text.Split(' ', ',');
                foreach (string s in numbers)
                {
                    string ss = s.Trim();
                    numberarray.Add(int.Parse(ss));
                }
                times++;
            }
            else
                return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        // object sender:表示触发事件的控件对象EventArgs e：表示事件数据的类的基类
       
        private void max_Click(object sender, EventArgs e)
        {
            ConvertStringToArray();
            MessageBox.Show(numberarray.Max().ToString());
        }

        private void min_Click(object sender, EventArgs e)
        {
            ConvertStringToArray();
            MessageBox.Show(numberarray.Min().ToString());
        }

        private void sum_Click(object sender, EventArgs e)
        {
            ConvertStringToArray();
            MessageBox.Show(numberarray.Sum().ToString());
        }


        private void average_Click(object sender, EventArgs e)
        {
            ConvertStringToArray();
            MessageBox.Show(((double)numberarray.Sum() / numberarray.Count).ToString());
        }

        private void up_TextChanged(object sender, EventArgs e)
        {

        }

        private void down_TextChanged(object sender, EventArgs e)
        {

        }

        private void prime_Click(object sender, EventArgs e)
        {
            try
            {
                upBoundary = int.Parse(up.Text);
                lowBoundary = int.Parse(down.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("not a valid number");
            }

            if(upBoundary <= lowBoundary)
            {
                MessageBox.Show("argument not legal");
                return;
            }

            // 判断一个数n是不是素数，就是判断除了1和它本身以外还有没有其他约数，这个约数是2到sqrt（n）这内的，如果不存在约数，则是素数

            string ans = "";
            int cnt = 0;
            for (int i = lowBoundary + 1; i < upBoundary; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    ans += i.ToString();
                    ans += " ";
                    cnt++;
                }

                if(cnt % 10 == 0)
                {
                    ans += Environment.NewLine;
                }
            }
            MessageBox.Show(ans);
        }
    }
}
