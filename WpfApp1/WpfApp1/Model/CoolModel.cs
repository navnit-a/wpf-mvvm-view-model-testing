using Microsoft.Practices.Prism.Mvvm;

namespace WpfApp1.ViewModel
{
    public class CoolModel : BindableBase
    {
        private string _Message;
        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                SetProperty(ref _Message, value);
            }
        }
    }
}