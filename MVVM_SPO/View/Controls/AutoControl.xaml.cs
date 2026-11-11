using MVVM_SPO.Data;
using MVVM_SPO.Model;
using System.Windows;
using System.Windows.Controls;

namespace MVVM_SPO.View.Controls
{

    public partial class AutoControl : UserControl
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public event EventHandler EventReg;
        public AutoControl()
        {
            InitializeComponent();
            DataContext = this;
        }
        private RelayCommand autorizationCommand;
        public RelayCommand AutorizationCommand
        {
            get
            {
                return autorizationCommand ??
                  (autorizationCommand = new RelayCommand(obj =>
                  {
                      if(!string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password))
                      {
                          User user = LocalDataContext.Users.FirstOrDefault(q => q.Login == Login 
                          && q.Password == Password);
                          if(user != null)
                          {

                          }
                      }
                      else
                      {
                          MessageBox.Show("Заполните все поля");
                      }
                  }));
            }
        }
        private RelayCommand exitCommand;
        public RelayCommand ExitCommand
        {
            get
            {
                return exitCommand ??
                  (exitCommand = new RelayCommand(obj =>
                  {
                      //todo выход из приложения
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
                      EventReg.Invoke(this, EventArgs.Empty);
                  }));
            }
        }
    }
}
