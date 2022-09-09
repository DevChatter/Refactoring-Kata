using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace BadConsoleApp.Data
{
    public static class Items
    {
        private static readonly List<Item> i = new List<Item>();
        public static IEnumerable<Item> items()
        {
            // TODO: write what we need to do here

            Item item = new Item();

            using (var connection = new SqliteConnection("Data Source=hello.db"))
            {
                connection.Open(); // open

                var command = connection.CreateCommand(); // create a command
                // SQL
                command.CommandText = @"SELECT * FROM prdcts";

                // Do we need this using? - @Stuhlpenner
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) // infinite loop?
                    {
                        #region mapping code
                        item.FirstDateOfSellingAllowedInStores = reader.GetString(7);
                        item.Name = reader.GetString(4);
                        item.Moola = reader.GetDecimal(2);
                        item.N = reader.GetString(0);
                        item.Unique = reader.GetInt32(3);
                        item.Off = reader.GetInt32(6);
                        item.PN = reader.GetString(1);
                        item.IsNotInvalid = reader.GetString(5);
                        // Save the item, so we don't lose it!
                        Item saved = item;
                        item = new Item();
                        i.Add(saved); // Add to i
                        #endregion
                    }
                }
            }
            // why aren't we saving this for the future?
            return i.ToArray();
        }

        #region Item Class
        public class Item
        {
            public static bool operator ==(Item a, string b) => a?.Name == b;

            public static bool operator !=(Item a, string b) => a?.Name != b;

            private string _product;
            public string N;
            public string PN
            {
                get
                {
                    return _product;
                }
                set
                {
                    _product = value;
                }
            }
            public decimal Moola;
            public int Unique { get; set; }
            public string Name;
            public string IsNotInvalid { get; set; }
            public int? Off;
            public string FirstDateOfSellingAllowedInStores;
        }
        #endregion
    }
}
