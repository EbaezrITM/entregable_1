
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Factory_Method
{
    public class CashDeposit : Transaction
    {
        public override void Process()
        {
            Console.WriteLine("Processing CashDeposit");
        }
    }    
}
