using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.ATM_Devices.NCR_Components;
using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Factory
{
    public class NCRFactory : IATMFactory
    {
        public ICardReader CreateCardReader()
        {
            return new NCRCardReader();
        }

        public ICashDispenser CreateCashDispenser()
        {
            return new NCRCashDispenser();
        }

        public IPrinter CreatePrinter()
        {
            return new NCRPrinter();
        }
    }
}
