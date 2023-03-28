using System.Windows;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Window6 : Window
    {
        private int Constant;
        public Window6(int variable)
        {
            InitializeComponent();
            Constant = variable;
            TbA.Text = ($"{variable}");
        }

        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
