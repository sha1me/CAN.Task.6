using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2, Constant3, Constant4;
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            string[] F = { "Иванов", "Козлов", "Петров", "Федоров", "Ильин", "Лешин", "Стрельцов", "Воронин", "Киров", "Осипов", "Калинин", "Смирнов", "Рудин", "Ломов", "Попов", "Винокур", "Абрамов", "Маликов", "Емельянов"}; 
            int[] T = new int[19];
            Random ran = new Random();
            int k, t1 = 0;
            int max = 0;
            for (int i = 0; i < 19; i++)
            {
                k = ran.Next(10, 37);
                T[i] = k;
                if (max < k)
                {
                    max = k;
                }
                if (k < max)
                {
                    t1 = k;
                }
            }


            Constant1 = max; Constant2 = t1; Constant3 = T[2]; Constant4 = T[3]; 
            Window2 win2 = new Window2(Constant1, Constant2, Constant3, Constant4);
            win2.Show();
        }
    }
}
