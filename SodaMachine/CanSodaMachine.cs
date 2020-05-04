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
        //construtor (spawn)
        public CanSodaMachine()
        {
            Inventory = new Inventory();
            Register = new SodaMachineRegister();
        }
        //member methods (can do)

        public void AcceptsCoinPayment(List<Coin> coins)
        {

        }

        public void ReturnsCoin() //add return type?? Coin ??
        {
           // return ;
        }

        public void DisplayCurrentInventoryWithPrice()
        {
            Console.WriteLine("Gape Soda in Inventory: " + Inventory.GrapeSodas.Count);
            Console.WriteLine("Orange Soda in Inventory: " + Inventory.OrangeSodas.Count);
            Console.WriteLine("Lemon Soda in Inventory: " + Inventory.LemonSodas.Count);
        }
    }
}
