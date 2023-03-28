using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2, Constant3, Constant4, Constant5, Constant6, Constant7, Constant8, Constant9;
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            int[,] A = new int[3, 3];
            int minRowSum = int.MaxValue, indexMinRow = 0;
            Random rnd = new Random();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(0, 100);
                    rowSum += A[i, j];
                    if (rowSum < minRowSum)
                    {
                        minRowSum = rowSum;
                        indexMinRow = i;
                    }
                    A[i, j] *= rowSum;
                }
            }
            Constant1 = A[0, 0];
            Constant2 = A[0, 1];
            Constant3 = A[0, 2];
            Constant4 = A[1, 0];
            Constant5 = A[1, 1];
            Constant6 = A[1, 2];
            Constant7 = A[2, 0];
            Constant8 = A[2, 1];
            Constant9 = A[2, 2];
            Window8 win1 = new Window8(Constant1, Constant2, Constant3, Constant4, Constant5, Constant6, Constant7, Constant8, Constant9);
            win1.Show();
        }
    }
}
