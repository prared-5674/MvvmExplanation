using PropertyChanged;

namespace MvvmTrail.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class AddExpenseViewModel
    {
        public double Expense { get; set; }
    }
}
