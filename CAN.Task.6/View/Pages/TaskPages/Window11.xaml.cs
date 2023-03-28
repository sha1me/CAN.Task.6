using System.Windows;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Window11 : Window
    {
        private int Constant1, Constant2;
        public Window11(int variable1, int variable2)
        {
            InitializeComponent();
            Constant1 = variable1;
            Constant2 = variable2;
            TbA.Text = ($"{variable1} {variable2}");
        }

        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
