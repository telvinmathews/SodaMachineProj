using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Inventory
    {
        public List<GrapeSoda> GrapeSodas;
        public List<OrangeSoda> OrangeSodas;
        public List<LemonSoda> LemonSodas;

        public Inventory()
        {
            AddGrapeSoda();
            AddOrageSoda();
            AddLemonSoda();
        }

        public void AddGrapeSoda()
        {
            GrapeSodas = new List<GrapeSoda>();
            for (int i = 0; i < 10; i++)
            {
                GrapeSoda grapeSoda = new GrapeSoda();
                GrapeSodas.Add(grapeSoda);
            }
        }

        public void AddOrageSoda()
        {
            OrangeSodas = new List<OrangeSoda>();
            for (int i = 0; i < 6; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                OrangeSodas.Add(orangeSoda);
            }
        }

        public void AddLemonSoda()
        {
            LemonSodas = new List<LemonSoda>();
            for (int i = 0; i < 3; i++)
            {
                LemonSoda lemonSoda = new LemonSoda();
                LemonSodas.Add(lemonSoda);
            }
        }
    }
}
