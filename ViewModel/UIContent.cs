using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System.Windows;
using System.Windows.Input;

namespace MvvmTrail.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class UIContent
    {
        public string ButtonContent  = "Hello World!";
        public ICommand ButtonCommand { get; set; }
        
        public UIContent() 
        { 
            ButtonCommand = new RelayCommand(OpenWindowAndSetString); 
        }

        public void OpenWindowAndSetString()
        {
            MessageBox.Show(ButtonContent);
        }

        
    }
}
