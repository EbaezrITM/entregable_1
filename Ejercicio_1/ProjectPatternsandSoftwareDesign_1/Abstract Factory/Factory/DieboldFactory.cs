using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.ATM_Devices.Diebold_Components;
using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Factory
{
    public class DieboldFactory : IATMFactory
    {
        public ICardReader CreateCardReader()
        {
            return new DieboldCardReader();
        }

        public ICashDispenser CreateCashDispenser()
        {
            return new DieboldCashDispenser();
        }

        public IPrinter CreatePrinter()
        {
            return new DieboldPrinter();
        }
    }
}
