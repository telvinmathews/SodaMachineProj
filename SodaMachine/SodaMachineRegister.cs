using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachineRegister
    {
        public List<Quarter> Quarters;
        public List<Dime> Dimes;
        public List<Nickel> Nickels;
        public List<Penny> Pennies;
        public double CurrentTotal;

        public SodaMachineRegister()
        {
            AddQuarters();
            AddDimes();
            AddNickels();
            AddPennies();
        }

        public void AddQuarters()
        {
            Quarters = new List<Quarter>();
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                Quarters.Add(quarter);
            }

        }

        public void AddDimes()
        {
            Dimes = new List<Dime>();
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                Dimes.Add(dime);
            }
        }

        public void AddNickels()
        {
            Nickels = new List<Nickel>();
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                Nickels.Add(nickel);
            }
        }

        public void AddPennies()
        {
            Pennies = new List<Penny>();
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                Pennies.Add(penny);
            }
        }
    }
}
