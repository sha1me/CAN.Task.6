using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        public int Constant;
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(TbA.Text);

            Constant = A;
            Window1 win1 = new Window1(Constant);
            win1.Show();
        }
    }
}
