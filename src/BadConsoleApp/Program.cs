using System;
using System.Collections.Generic;
using System.Text;
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

            // Loop over the hsopping ietms
            for (var a = args.Length - 1; a >= 0; a--)
            {
                // Use for loop for speed
                for (double b = 0; b < Shopping.Items.Count; b++)
                {
                    // compare two varbiales
                    if (Shopping.Items[(int)b] == args[a])
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(Shopping.Items[(int)b].Name);
                        sb.Append(":");
                        sb.Append(" ");
                        b = Shopping.Items[(int)b].Cost;
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
        public static bool operator ==(Shopping a, string b) => a?.Name == b;

        public static bool operator !=(Shopping a, string b) => a?.Name != b;

        public Shopping(string name, double price)
        {
            Name = name;
            Cost = price;
        }

        public string Name { get; set; }
        public double Cost { get; set; }

        public static List<Shopping> Items = new List<Shopping>
        {
            new Shopping("Bruschetta Toast Crunch", 3.37),
            new Shopping("Pizza Crunch Cereal", 2.09),
            new Shopping("Milk", 5.37), // No one will ever sell anything, but a gallon. Who needs halfs?
            new Shopping("Pizza", 1.42),
        };
    }
}
