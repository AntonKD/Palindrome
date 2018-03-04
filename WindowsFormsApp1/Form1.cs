using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // проверка на палиндромность
        private static bool IsPalindrome(string str)
        {
            int i = 0, j = str.Length - 1;
            while (i < j)
                if (str[i++] != str[j--]) return false; // сравниваем наши цифры
            return true;
        }

        // находим самый большой палиндром
        private int max_Palindrome()
        {
            int[] array = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                array[i] = Convert.ToInt32(listBox1.Items[i]);
            }

            int max = array[0];
            for (long i = 0; i < array.Length; i++)
            {
                if ((max < array[i]))
                {
                    max = array[i];
                }
            }

            return max;

        }

        //возвращает сами сомножители.
         private int Number(int first_number, int second_number)
        {
            

            if ((first_number * second_number).ToString() == label3.Text)
            {
                label1.Text = first_number.ToString();// 1 простой множитель
                label2.Text = second_number.ToString();// 2 простой множитель

            }
            return 0;

        }

        //проверяем являеться ли число простым 
        private static bool Сheck_the_Number(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;


        }

        // глобальние переменные
        int first_number, second_number;
        long number;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         //10000 99999
            for (first_number = 10000; first_number < 99999; first_number++)
            {
                if (Сheck_the_Number(first_number) == true)
                {
                    for (second_number = 10000; second_number < 99999; second_number++)
                    {

                        // && 
                        if (Сheck_the_Number(second_number) == true)
                        {
                            number = first_number * second_number;

                            if (IsPalindrome(number.ToString()) == true) // проверка числа на палиндромность
                            {
                                listBox1.Items.Add(number);
                                label3.Text = max_Palindrome().ToString();
                                Number(first_number, second_number);
                            }
                        }
                    }
                }
            }
        }

    }
}
