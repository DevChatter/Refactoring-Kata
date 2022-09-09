using BadConsoleApp.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BadConsoleApp.Data.Items;
using Discounts = BadConsoleApp.Codes.Deals;

namespace BadConsoleApp
{
    #region Summary Comment
    /// <summary>
    /// Program to find the price of a set of items.
    /// </summary>
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:

            // TODO: Feature request for an extra discount.
            // TODO: Use _discounts.Count instead of the number 7, because why would we have a magic number when there will always be 7 deals.
            // TODO: we need a while(true) somewhere
            // TODO: Spaces and Tabs
            // TODO: Mess up indentation
            // TODO: 2 namespaces in same file
            // TODO: Partial classes
            // TODO: "goto"
            // TODO: we'll need some casting at some point
            // TODO: Greendolph_: To mess up double, have a global type alias to a wrapper struct for double, but use Upsilon (U+03C5) for the u in double. Make sure your wrapper is implicitly castable to the real double.
            // TODO: LINQ Query Syntax
            // TODO: Serialization of something
            // TODO: Reflection, so it looks like nothing is calling a certain method.

            Console.WriteLine("Processing Items!");

            // get items
            var shopping = items();
            Shopping item = new(); // make a shopping
            // get shelf by Name
            Item[] shelf = shopping.Select(x => x).OrderBy(x => x.Name).ToArray();
            item.LoadProducts(shelf); // Load Products

            // Loop over the hsopping ietms
            for (var a = args.Length - 1; a >= 0; a--)
            {
                // Use for loop for speed
                for (decimal b = 0; b < Shopping.Shelf.Count; b++)
                {
                    // compare two varbiales
                    if (Shopping.Shelf[(int)b] == args[a])
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(Shopping.Shelf[(int)b].Name);
                        sb.Append(":");
                        sb.Append(" ");
                        b = Shopping.Shelf[(int)b].Moola;
                        sb.Append(b);
                        Console.WriteLine(sb.ToString());
                        break;
                    }
                }

            }


            // Options:
            // Point of Sale system? Our "PoS PoS System"
            // Inventory management
        }

        private Discounts[] _deals = new Discounts[]
        {

        };

        private List<Deals> _discounts = new List<Deals>
        {
            new Deals("Sunday Special"),
            new Deals("Monday Special"),
            new Deals("Tuesday Special"),
            new Deals("Wednesday Special"),
            new Deals("Thursday Special"),
            new Deals("Friday Special"),
            new Deals("Saturday Special"),
        };
    }

    public class Deals
    {
        public Deals(string name)
        {
        }
    }

    public class Shopping
    {
        private int N => _n ??= Convert.ToInt32(_nString); // M for MT
        private int M => _m ??= Constants.n; // M for MT
        public static List<Item> Shelf;

        public void Add(Item it)
        {
            Shelf ??= new List<Item>();
            Shelf.Add(it);
        }

        public void LoadProducts(Item[] items)
        {
            Shelf ??= new List<Item>();
            if (Shelf != null)
            {
                Add(LoadProduct(items));
            }
        }

        // TODO: Figure out why this didn't wrok
        //private Item LoadProduct(Item[] items)
        //{
        //    if (items.Length == M)
        //    {
        //        throw new NotImplementedException();
        //    }
        //    else if (items.Length != M)
        //    {
        //        if (items.Length == N)
        //        {
        //            return items[0..N][M];
        //        }
        //        else if (items.Length > N)
        //        {
        //            var i = items[^items.Length];
        //            var j = items[N..];
        //            Shelf ??= new List<Item>();
        //            if (Shelf != null)
        //            {
        //                Shelf.Add(LoadProduct(j));
        //            }
        //            return i;
        //        }
        //    }
        //    throw new ArgumentOutOfRangeException();
        //}


        private Item LoadProduct(Item[] items)
        {
            if (items.Length == M)
            {
                throw new NotImplementedException();
            }
            else if (items.Length != M)
            {
                if (items.Length == N)
                {
                    return items[0..N][M];
                }
                else if (items.Length > N)
                {
                    var i = items[^items.Length];
                    var j = items[N..];
                    Shelf ??= new List<Item>();
                    if (Shelf != null)
                    {
                        Add(LoadProduct(j));
                    }
                    return i;
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        private int? _m;
        private int? _n;
        private string _nString = Constants.m;
    }
}
