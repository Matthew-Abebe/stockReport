using System;
using System.Collections.Generic;

namespace stockReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("AAPL", "Apple");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("TWTR", "Twitter");

            string GM = stocks["GM"];
            string AAPL = stocks["AAPL"];
            string MSFT = stocks["MSFT"];
            string TWTR = stocks["TWTR"];

            Dictionary<string, int> purchases = new Dictionary<string, int>();
            purchases.Add("AAPL", 500);
            purchases.Add("GM", 250);
            purchases.Add("MSFT", 300);
            purchases.Add("TWTR", 200);

        }
    }
}
