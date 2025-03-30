using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.ATM_Devices.Diebold_Components
{
    public class DieboldCashDispenser : ICashDispenser
    {
        public void DispenseCash()
        {
            Console.WriteLine("Dispensing cash with Diebold dispenser...");
        }
    }
}
