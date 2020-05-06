using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            GrapeSoda grape = new GrapeSoda();
            OrangeSoda orangeSoda = new OrangeSoda();
            LemonSoda lemonSoda = new LemonSoda();
            //Customer customer = new Customer();
            //CanSodaMachine canSodaMachine = new CanSodaMachine();
            //customer.DisplayUserAvailibleMoney();
            //canSodaMachine.DisplayCurrentInventoryWithPrice(grape, orangeSoda, lemonSoda);
            //Console.ReadLine();
            Simulation simulation = new Simulation();
            simulation.RunSimulation(grape, orangeSoda, lemonSoda);
        }
    }
}
