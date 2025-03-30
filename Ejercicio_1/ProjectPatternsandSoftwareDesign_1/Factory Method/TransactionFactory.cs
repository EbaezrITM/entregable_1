using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Factory_Method
{
    public class TransactionFactory
    {
        /// <summary>
        /// Create a transaction object based on the type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static Transaction CreateTransaction(string type)
        {
            switch (type)
            {
                case "CashWithdrawal":
                    return new CashWithdrawal();
                case "dCashDeposit":
                    return new CashDeposit();
                case "BalanceInquiry": 
                    return new BalanceInquiry();
                default: 
                    throw new ArgumentException("Invalid transaction type");
            }
        }
    }
}
