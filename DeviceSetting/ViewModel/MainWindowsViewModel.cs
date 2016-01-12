using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DeviceSetting.Model;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows;

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
            this.OkCommand = new OkCommandImpl();
        }               

        public ObservableCollection<string> PrinterList
        {
            get { return this.printers; }
        }

        public string FullName
        {
            get
            {
                return printer.PrinterName;
            }            
        }

        private string _selectedPrinter;
        public string SelectedPrinter
        {
            get { return _selectedPrinter; }
            set
            {
                _selectedPrinter = value;
                NotifyPropertyChanged("SelectedPrinter");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string v)
        {            
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public ICommand OkCommand { get; private set; }

    }

    class OkCommandImpl : ICommand
    {
        public bool CanExecute(object parameter) { return true; }
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MessageBox.Show("コマンドが実行されました。");
        }
    }
}

