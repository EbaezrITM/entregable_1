using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Abstract_Factory.ATM_Devices.Diebold_Components
{
    class DieboldCardReader : ICardReader
    {
        public void ReadCard()
        {
            Console.WriteLine("Reading card with Diebold reader...");
        }
    }
}
