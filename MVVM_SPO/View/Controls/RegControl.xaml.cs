using MVVM_SPO.Model;
using System.Windows.Controls;

namespace MVVM_SPO.View.Controls
{
    public partial class RegControl : UserControl
    {
        public event EventHandler EventAuth;
        public RegControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private RelayCommand exitCommand;
        public RelayCommand ExitCommand
        {
            get
            {
                return exitCommand ??
                  (exitCommand = new RelayCommand(obj =>
                  {
                      EventAuth.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
        private RelayCommand regCommand;
        public RelayCommand RegCommand
        {
            get
            {
                return regCommand ??
                  (regCommand = new RelayCommand(obj =>
                  {
                      //todo переход на регистрацию 
                  }));
            }
        }
    }
}
