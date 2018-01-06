using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCorrect
{

    //************ Fixed Points ********************
     
    // Bank Object was a model class
    // Calculate Interest is a seperate function.
    // Adding a new property to Bank object 
    // New Rule for the calculate interest


    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal AccountBalance { get; set; }
    }

    public class BankAccount : IBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }

    public interface IInterestCalculator
    {
        decimal CalculateInterest(IBankAccount account);

    }

    public class InterestCalculator : IInterestCalculator
    {
        public decimal CalculateInterest(IBankAccount account)
        {
            // Write your logic here
            return 1000;
        }
    }

}
