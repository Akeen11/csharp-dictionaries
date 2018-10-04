using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {

            Dictionary<string, string> stocks = new Dictionary<string, string> ();
            stocks.Add ("GM", "General Motors");
            stocks.Add ("CAT", "Caterpillar");
            stocks.Add ("AAPL", "Apple");
            stocks.Add ("GE", "General Electric");
            stocks.Add ("MSFT", "Microsoft");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>> ();

            purchases.Add (new Dictionary<string, double> () { { "GE", 230.21 } });
            purchases.Add (new Dictionary<string, double> () { { "GE", 580.98 } });
            purchases.Add (new Dictionary<string, double> () { { "GE", 406.34 } });
            purchases.Add (new Dictionary<string, double> () { { "AAPL", 1500.72 } });
            purchases.Add (new Dictionary<string, double> () { { "CAT", 769.98 } });
            purchases.Add (new Dictionary<string, double> () { { "MSFT", 157.89 } });
            purchases.Add (new Dictionary<string, double> () { { "AAPL", 1200.15 } });
            purchases.Add (new Dictionary<string, double> () { { "GM", 428.65 } });
            purchases.Add (new Dictionary<string, double> () { { "CAT", 438.97 } });

            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock


                From the three purchases above, one of the entries
                in this new dictionary will be...
                    {"General Electric", 1217.53}

                Replace the questions marks below with the correct types.
            */

            Dictionary<string, double> stockReport = new Dictionary<string, double> ();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */

            foreach (Dictionary<string, double> purchase in purchases) {

                {

                    foreach (KeyValuePair<string, double> transaction in purchase) {

                        // Does the full company name key already exist in the `stockReport`?

                        string fullCompanyName = stocks[transaction.Key];

                        // If it does, update the total valuation

                        if (stockReport.ContainsKey (fullCompanyName)) {

                            stockReport[fullCompanyName] += transaction.Value;

                        } else {

                            stockReport[fullCompanyName] = transaction.Value;

                        }
                    }
                }
            }
            /*
                If not, add the new key and set its value.
                You have the value of "GE", so how can you look
                the value of "GE" in the `stocks` dictionary
                to get the value of "General Electric"?
            */

            foreach (KeyValuePair<string, double> valuation in stockReport) {

                Console.WriteLine ($"{valuation.Key} has a valuation of {valuation.Value.ToString("C")}");

            }
        }
    }
}