using System.Windows;

namespace CAN.Task._6.View.Pages.TaskPages
{
    public partial class Window1 : Window
    {
        private int Constant;
        public Window1(int variable)
        {
            InitializeComponent();
            Constant = variable;
            TbA.Text = ($"{variable}");
        }

        private void Btn101_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
