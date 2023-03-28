using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2, Constant3, Constant4, Constant5, Constant6, Constant7, Constant8, Constant9;
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            int I = Convert.ToInt32(TbI.Text);
            int J = Convert.ToInt32(TbJ.Text);
            int[] N = new int[9];
            Random ran = new Random();
            int k;
            for (int i = 0; i < 9; i++)
            {
                    k = ran.Next(1, 99);
                    k *= 3;
                    N[i] = k;
            }

            Constant1 = N[0];
            Constant2 = N[1];
            Constant3 = N[2];
            Constant4 = N[3];
            Constant5 = N[4];
            Constant6 = N[5];
            Constant7 = N[6];
            Constant8 = N[7];
            Constant9 = N[8];

            Window3 win1 = new Window3(Constant1, Constant2, Constant3, Constant4, Constant5, Constant6, Constant7, Constant8, Constant9);
            win1.Show();
        }
    }
}
