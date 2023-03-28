using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2;
        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(TbN.Text);
            int m = Convert.ToInt32(TbM.Text);
            int[,] mas = new int[n, m];
            int max = 0;
            int t1 = 0, t2 = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int min = mas[i, 0];
                for (int j = 1; j < m; j++)
                {
                    if (mas[i, j] > min)
                    {
                        max = mas[i, j];
                        t1 = i;
                        t2 = j;
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
