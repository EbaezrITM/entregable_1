using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.ATM_Devices.NCR_Components
{
    public class NCRCardReader : ICardReader
    {
        public void ReadCard()
        {
            Console.WriteLine("Reading card with NCR reader...");
        }
    }
}
