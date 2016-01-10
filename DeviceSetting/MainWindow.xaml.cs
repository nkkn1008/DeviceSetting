using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DeviceSetting.ViewModel;
namespace DeviceSetting
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var p = new MainWindowsViewModel();
            this.DataContext = p;
        }
    }

    [ValueConversion(typeof(string), typeof(bool))]
    public class HogeConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType,
          object parameter, System.Globalization.CultureInfo culture)
        {
            return true;
        }

        public object ConvertBack(object value, System.Type targetType,
          object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
