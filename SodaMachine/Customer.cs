using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        public Wallet Wallet;

        public Customer()
        {
            Wallet = new Wallet();
        }

        //display user avialble money
        //display current inventory of soda to pick from with price
        //take user input option
        //user pays money based on input
        //user money decreases

        // if user does not have enough money
        // display go home you broke!
        // soda machine gives back money
        // display Good bye
        // end simulation

        //can soda machine inventory decrease
        //if soda is not avalibe 
        // display not avalivable
        // soda machine gives back change
        // repeat step 1

        //can soda machine register decreases
        //if user pay more than the value of the soda 
        // machine give back the differnce in avalivable coins

        public void DisplayUserAvailibleMoney()
        {
            Console.WriteLine("You have: " + "$" + Wallet.Money + " in cash availible");
        }

       


        public void BuySoda(double transactionAmount)
        {
            Wallet.Money -= transactionAmount;
        }
    }
}
