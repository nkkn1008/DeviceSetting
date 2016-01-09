using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Printing;
namespace DeviceSetting.Model
{
    class Printer
    {
        public Printer()
        {
            LocalPrintServer server = new LocalPrintServer();
            var queues = server.GetPrintQueues();            
            var queList = queues.
                Select(x => x.FullName).
                ToList();
            printers = new ObservableCollection<string>(queList);
                                
        }
        public string PrinterName { get; set; }
        public ObservableCollection<string> printers { get; set; }
    }
}
