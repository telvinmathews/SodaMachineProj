using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class CanSodaMachine
    {
        //member variables (has a)
        public Inventory Inventory;
        public SodaMachineRegister Register;
        public double TempCoinRegister;
        //construtor (spawn)
        public CanSodaMachine()
        {
            Inventory = new Inventory();
            Register = new SodaMachineRegister();
        }
        //member methods (can do)


        public double AcceptsCoinPayment(List<Coin> coins, Coin coin, Can can)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                TempCoinRegister = coin.value;
                if (TempCoinRegister < can.Value)
                {
                    return TempCoinRegister;
                }
            }
        }

        public void ReturnsCoin() //add return type?? Coin ??
        {
           // return ;
        }

        public void DisplayCurrentInventoryWithPrice(GrapeSoda grape, OrangeSoda orangeSoda, LemonSoda lemonSoda)
        {
            //Why does C# not print zero at the behinde the decimal point
            Console.WriteLine($"Gape cost:  ${grape.Value} cents");
            Console.WriteLine($"Organge cost:  ${orangeSoda.Value} cents");
            Console.WriteLine($"Lemon cost: ${lemonSoda.Value} cents");
            Console.WriteLine("Gape Soda in Inventory: " + Inventory.GrapeSodas.Count);
            Console.WriteLine("Orange Soda in Inventory: " + Inventory.OrangeSodas.Count);
            Console.WriteLine("Lemon Soda in Inventory: " + Inventory.LemonSodas.Count);
        }
    }
}
