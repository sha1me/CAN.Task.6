using System.Windows;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Window2 : Window
    {
        private int Constant1, Constant2, Constant3, Constant4;

        public Window2(int variable1, int variable2, int variable3, int variable4)
        {
            InitializeComponent();
            Constant1 = variable1; Constant2 = variable2; Constant3 = variable3; Constant4 = variable4;
            TbA.Text = ($"{variable1}");
            TbB.Text = ($"{variable2}");
            TbC.Text = ($"{variable3}");
            TbD.Text = ($"{variable4}");

        }
        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
