using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket
{
    public class Cart
    {
        public List<Item> items;
        public int size;
        public int quantity;

        public Cart()
        {
            items = new List<Item>();
            size = 0;
            quantity = 3;
        }
        public void AddOneToChart(Item item)
        {
            if (size >= 10)
            {
                throw new Exception("Nova greska");
            }

            items.Add(item);
            size++;
        }

        public void AddMultipleToChart(Item item, int num)
        {
            if (size >= 10)
            {
                throw new Exception("Nova greska");
            }

            for(int i=0; i<num;i++)
            {
                items.Add(item);
                size++;
            }
        }
    }
}
