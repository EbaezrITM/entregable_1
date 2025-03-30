using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Factory
{
    public interface IATMFactory
    {
        ICardReader CreateCardReader();
        ICashDispenser CreateCashDispenser();
        IPrinter CreatePrinter();
    }
}
