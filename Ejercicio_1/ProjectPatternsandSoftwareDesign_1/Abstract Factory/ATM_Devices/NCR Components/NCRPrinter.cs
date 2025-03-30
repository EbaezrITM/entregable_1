using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.ATM_Devices.NCR_Components
{
    public class NCRPrinter : IPrinter
    {
        public void PrintReceipt()
        {
            Console.WriteLine("Printing receipt with NCR printer...");
        }
    }
}
