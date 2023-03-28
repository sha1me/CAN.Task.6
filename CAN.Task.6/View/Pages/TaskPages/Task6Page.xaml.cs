using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }
        public int Constant;
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            int M = Convert.ToInt32(TbA.Text);
            int N = Convert.ToInt32(TbB.Text);
            int[,] mas = new int[M, N];
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                }
            }
            for (int i = 1; i < M; i++)
            {
                for (int t = 0; t < N; t++)
                {
                    if (mas[0, t] == mas[i, t])
                    {
                        count++;
                    }
                }
            }
            Constant = count;
            Window6 win1 = new Window6(Constant);
            win1.Show();
        }
    }
}