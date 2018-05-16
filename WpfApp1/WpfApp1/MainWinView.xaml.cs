using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    ///     Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            DataContext = new CoolViewModel();
        }
    }
}