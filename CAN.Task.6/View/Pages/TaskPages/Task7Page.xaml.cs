using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2;
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(TbA.Text);
            int B = Convert.ToInt32(TbB.Text);
            int k = Convert.ToInt32(TbK.Text);
            int[,] mas = new int[A, B];
            int t1 = 0, t2 = 0;
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    {
                        if (mas[i, j] == k)
                        {
                            t1 = i;
                            t2 = j;
                        }
                    }
                }
            }
            Constant1 = t1;
            Constant2 = t2;
            Window7 win1 = new Window7(Constant1, Constant2);
            win1.Show();
        }
    }
}
