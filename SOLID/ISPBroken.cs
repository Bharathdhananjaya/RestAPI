using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IMachine
    {
         bool print(List<Item> item);
         bool staple(List<Item> item);
         bool fax(List<Item> item);
         bool scan(List<Item> item);
         bool photoCopy(List<Item> item);
    }
    // Code implementing the IMachine interface. 

   class Item
    {
        // properties
    }

    class Machine : IMachine
    {
        public Machine()
        {
        }

        public bool print(List<Item> item)
        {
            // Print the items.
            Console.WriteLine("All Items printed" + item.Count());
            return true;
        }

        public bool staple(List<Item> item)
        {
            // Staple the items.
            Console.WriteLine("Items stapled" + item.Count());
            return true;
        }

        public bool fax(List<Item> item)
        {
            // Fax the items.
            Console.WriteLine("All Items Faxed" + item.Count());
            return true;
        }

        public bool scan(List<Item> item)
        {
            // Scan the items.
            Console.WriteLine("All Items Scanned" + item.Count());
            return true;
        }

        public bool photoCopy(List<Item> item)
        {
            // Xerox the items.
            Console.WriteLine("All Items Photo copied" + item.Count());
            return true;
        }

        public bool Scaning(List<Item> item)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopying(List<Item> item)
        {
            throw new NotImplementedException();
        }
    }
}
