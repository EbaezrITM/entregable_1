using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Factory_Method
{
    public abstract class Transaction
    {
        /// <summary>
        /// Process the transaction
        /// </summary>
        public abstract void Process();
    }
}
