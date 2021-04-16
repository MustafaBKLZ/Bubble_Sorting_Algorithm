using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bubble_Sorting_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_bubble_short_Click(object sender, EventArgs e)
        {
            Bubble_Short();
        }
        int[] Sayilar = new int[] { 5, 6, 8, 1, 88, 99, 78, 45, 36, 25, 12, 9, 7 };
        void Bubble_Short()
        {
            for (int i = 0; i < Sayilar.Count(); i++)
                for (int j = 0; j < (Sayilar.Count() - i - 1); j++)
                    if (Sayilar[j] > Sayilar[j + 1])
                    {
                        swap(Sayilar[j], j, Sayilar[j + 1], j + 1);
                        Yazdir();
                    }
        }
        void swap(int num1, int index1, int num2, int index2)
        {
            Sayilar[index1] = num2;
            Sayilar[index2] = num1;
        }

        void Yazdir()
        {
            textBox1.Text += (string.Join(",", Sayilar)) + Environment.NewLine;
        }


    }
}
