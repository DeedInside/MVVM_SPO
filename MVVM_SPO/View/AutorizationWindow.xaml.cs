using MVVM_SPO.ViewModel;
using System.Windows;

namespace MVVM_SPO.View
{

    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
            DataContext = new AutorizationVM();
        }
    }
}
