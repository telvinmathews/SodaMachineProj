using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Simulation
    {
        public CanSodaMachine CanSodaMachine;
        public Customer Customer;

        public Simulation()
        {
            CanSodaMachine = new CanSodaMachine();
            Customer = new Customer();
        }

        public void UserInput(GrapeSoda grapeSoda, OrangeSoda orangeSoda, LemonSoda lemonSoda)
        {
            Console.WriteLine("Pick a soda: Type 1 for Grapesoda, 2 for Orangesoda, or 3 for Lemonsoda");
            string userInput = Console.ReadLine();
            if (userInput == "1" && Customer.Wallet.Money >= grapeSoda.Value && CanSodaMachine.Inventory.GrapeSodas.Count > 0)
            {
                Customer.BuySoda(grapeSoda.Value);
                CanSodaMachine.Inventory.GrapeSodas.Remove(grapeSoda);
            }
            else if (userInput == "2" && Customer.Wallet.Money >= orangeSoda.Value && CanSodaMachine.Inventory.OrangeSodas.Count > 0)
            {
                Customer.BuySoda(orangeSoda.Value);
                CanSodaMachine.Inventory.OrangeSodas.Remove(orangeSoda);
            }
            else if (userInput == "3" && Customer.Wallet.Money >= lemonSoda.Value && CanSodaMachine.Inventory.LemonSodas.Count > 0)
            {
                Customer.BuySoda(lemonSoda.Value);
                CanSodaMachine.Inventory.LemonSodas.Remove(lemonSoda);
            }
            else
            {
                Console.WriteLine("wrong input");
                UserInput(grapeSoda, orangeSoda, lemonSoda);
            }
        }

        public void RunSimulation(GrapeSoda grape, OrangeSoda orange, LemonSoda lemon)
        {
            Customer.DisplayUserAvailibleMoney();
            CanSodaMachine.DisplayCurrentInventoryWithPrice(grape, orange, lemon);
            UserInput(grape, orange, lemon);
            Console.ReadLine();
        }
    }
}
