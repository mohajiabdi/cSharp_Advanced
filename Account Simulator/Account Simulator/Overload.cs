using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulator
{
    internal class Overload
    {
        // backing Field
        private decimal _balance;

        // parameterized Constructor 
        public Overload(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        // Balance Property Read_only
        public decimal Balance {  get { return _balance; } }

        //Deposit Method
        public void Deposit(decimal amount) { 
            _balance += amount;
        }

        //Method  Withdraw
        public void Withdraw(decimal amount) { 
            _balance -= amount;
        }
    }
}
