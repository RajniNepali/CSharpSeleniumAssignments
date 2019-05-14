//Define a class which will accept Principal, interest rate and tenure and calculate the interest rate and print it to console. Use OOP’s principles.
using System;
namespace Scripts1
{
    public class Assignment5
    {
        public int CalculateInterest(int principal,int interestRate,int tenure)
        {
            int interest=0;
            interest=(principal*interestRate*tenure)/100;
            return interest;
        }
    }
}