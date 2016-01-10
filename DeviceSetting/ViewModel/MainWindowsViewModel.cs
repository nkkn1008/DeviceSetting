using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DeviceSetting.Model;

namespace DeviceSetting.ViewModel
{
    class MainWindowsViewModel : INotifyPropertyChanged
    {
        private Printer printer;
        private ObservableCollection<string> printers;
        public MainWindowsViewModel()
        {
            this.printer = new Printer();
            this.printers = printer.printers;
        }               

        public ObservableCollection<string> PrinterList
        {
            get { return this.printers; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string v)
        {            
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}
