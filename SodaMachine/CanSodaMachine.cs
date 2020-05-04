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

        public void AcceptsCoinPayment()
        {

        }

        public void ReturnsCoin() //add return type?? Coin ??
        {
           // return ;
        }
    }
}
