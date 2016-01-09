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
    class PrinterViewModel : INotifyPropertyChanged
    {
        private Printer printer;
        private ObservableCollection<string> printers;
        public PrinterViewModel()
        {
            this.printer = new Printer();
            this.printers = printer.printers;
        }        
        
        public string FullName
        {
            get { return printer.PrinterName; }
            set
            {
                printer.PrinterName = value;
                NotifyPropertyChanged("FullName");
            }
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
