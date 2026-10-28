using System.Windows;

namespace MVVM_SPO.View
{

    public partial class Main : Window
    {
        public Main()
        {
            AutorizationWindow autorization = new AutorizationWindow();

            if(autorization.ShowDialog() == true) 
            { 
                InitializeComponent();
            }
            else
            {
                Close();
            }
        }
    }
}
