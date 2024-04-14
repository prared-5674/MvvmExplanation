using PropertyChanged;

namespace MvvmTrail.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class IncomeViewViewModel
    {
        public double Income {  get; set; }
    }
}
