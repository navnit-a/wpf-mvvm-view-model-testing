using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace WpfApp1.ViewModel
{
    public class CoolViewModel : BindableBase
    {
        private CoolModel coolModel;
        public ICommand ClickCommand { get; private set; }

        public CoolViewModel()
        {
            coolModel = new CoolModel();
            ClickCommand = new DelegateCommand(ClickedMethod);
        }

        public CoolModel CoolModel
        {
            get { return coolModel; }
            set { SetProperty(ref coolModel, value); }
        }

        private void ClickedMethod()
        {
            CoolModel.Message = "You Have Clicked the button";
        }
    }
}