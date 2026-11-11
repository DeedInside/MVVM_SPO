using MVVM_SPO.View.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MVVM_SPO.ViewModel
{
    public class AutorizationVM: INotifyPropertyChanged
    {
        private UserControl selectedUserControl;
        public UserControl SelectUserControl 
        {
            get
            {
                return selectedUserControl;
            }
            set
            {
                selectedUserControl = value;
                OnPropertyChanged("SelectUserControl");
            }
        }
    
        public AutorizationVM() 
        {
            AutoControl auto = new AutoControl();
            auto.EventReg += SwapControl;
            SelectUserControl = auto;
        }

        private void SwapControl(object sender, EventArgs e)
        {
            if(sender is AutoControl auto)
            {
                auto.EventReg -= SwapControl;
                RegControl reg = new RegControl();
                reg.EventAuth += SwapControl;
                SelectUserControl = reg;
            }
            else if(sender is RegControl reg)
            {
                reg.EventAuth -= SwapControl;
                AutoControl auto1 = new AutoControl();
                auto1.EventReg += SwapControl;
                SelectUserControl = auto1;
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
