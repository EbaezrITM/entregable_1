using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_1.Singleton
{
    public class ATMSession
    {
        private static ATMSession _instance;
        private static readonly Object _lock = new Object();

        public string UserId { get; private set; }

        private ATMSession(string userId)
        {
            this.UserId = userId;

        }

        public static ATMSession GetInstance(string userId)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ATMSession(userId);
                    }
                }
            }
            return _instance;
        }

        public void LogOut()
        {
            lock (_lock)
            {
                _instance = null;
                Console.WriteLine("User logged out");
            }
        }

    }
}
