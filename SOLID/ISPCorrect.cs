using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCorrect
{
    class Item
    {

    }
    interface IPrinter
    {
         bool Print(List<Item> Items);
    }

    class Printer : IPrinter
    {
        public bool Print(List<Item> Items)
        {
            //foreach (var item in Item)
                //print(item);
                return true;
        }

        //Other definitions...
    }

    interface IStaple
    {
        bool Stapling(List<Item> Items);
    }

    class Staple : IStaple
    {
        public bool Stapling(List<Item> Items)
        {
            //foreach (var item in Items)
            //    Staple(item);
            return true;
        }

        //Other definitions...
    }

    interface IFax
    {
         bool Faxing(List<Item> Items);
    }

    class Fax : IFax
    {
        public bool Faxing(List<Item> Items)
        {
            return true;
        }

        //Other definitions...
    }

    interface IScan
    {
         bool Scanning(List<Item> Items);
    }

    class Scan : IScan
    {
        public bool Scanning(List<Item> Items)
        {
            return true; ;
        }

        //Other definitions...
    }

    interface IPhotoCopy
    {
         bool PhotoCopying(List<Item> Items);
    }

    class PhotoCopy : IPhotoCopy
    {
        public bool PhotoCopying(List<Item> Items)
        {
            return true;
        }

        //Other definitions...
    }

    interface IMachine : IPrinter, IFax, IScan, IPhotoCopy, IStaple
    {
         bool Print(List<Item> item);
         bool Stapling(List<Item> item);
         bool Faxing(List<Item> item);
         bool Scaning(List<Item> item);
         bool PhotoCopying(List<Item> item);
    }

    class Machine : IMachine
    {
        private IPrinter Printer { get; set; }
        private IFax Fax { get; set; }
        private IScan Scan { get; set; }
        private IPhotoCopy Photocopy { get; set; }
        private IStaple Staple { get; set; }

        // Notice how the dependencies are injected through constructor (constructor dependency injection)
        public Machine(IPrinter printer, IFax fax, IScan scan, IPhotoCopy photoCopy, IStaple staple)
        {
            this.Printer = printer;
            this.Fax = fax;
            this.Scan = scan;
            this.Photocopy = photoCopy;
            this.Staple = staple;
        }

        public bool Print(List<Item> item)
        {
            // Print the items.
            Console.WriteLine("All Items printed" + item.Count());
            return true;
        }

        public bool Stapling(List<Item> item)
        {
            // Staple the items.
            Console.WriteLine("Items stapled" + item.Count());
            return true;
        }

        public bool Faxing(List<Item> item)
        {
            // Fax the items.
            Console.WriteLine("All Items Faxed" + item.Count());
            return true;
        }

        public bool Scanning(List<Item> item)
        {
            // Scan the items.
            Console.WriteLine("All Items Scanned" + item.Count());
            return true;
        }

        public bool photoCopying(List<Item> item)
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
