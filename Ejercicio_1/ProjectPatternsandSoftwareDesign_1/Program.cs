using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Factory;
using ProjectPatternsandSoftwareDesign_1.Abstract_Factory.Interfaces;
using ProjectPatternsandSoftwareDesign_1.Factory_Method;
using ProjectPatternsandSoftwareDesign_1.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            // Factory Method Usage
            Transaction transaction = TransactionFactory.CreateTransaction("CashWithdrawal");
            transaction.Process();

            // Abstract Factory Usage
            IATMFactory atmFactory = new DieboldFactory();

            // Singleton Usage
            ATMSession session = ATMSession.GetInstance("User123");

            ICardReader reader = atmFactory.CreateCardReader();            
            ICashDispenser dispenser = atmFactory.CreateCashDispenser();
            IPrinter printer = atmFactory.CreatePrinter();        
           

            reader.ReadCard();
            Console.WriteLine($"Session started for: {session.UserId}");

            dispenser.DispenseCash();
            printer.PrintReceipt();           
           
            
            session.LogOut();
        }
    }
}
