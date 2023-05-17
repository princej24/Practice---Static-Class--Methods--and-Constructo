using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class DailyTransactions
    {
        private static List<Transaction> _transactions;

        static DailyTransactions()
        {
            _transactions = new List<Transaction>();
            AddTransaction("adidas blue back pack ", 55.00);
            AddTransaction("comme des garcons", 150.00);
            AddTransaction("vans VALENTINES TALL CUFF BEANIE", 15.00);
            AddTransaction("Chuck 70 AT-CX Colorblock", 69.00);
            AddTransaction("Chuck Taylor All Star Black Joy", 100.00);

            
        }

        public static List<Transaction> Transactions => _transactions;

        public static void AddTransaction(string name, double amount)
        {
            _transactions.Add(new Transaction(name, amount));
        }

        public static double taxTotal()
        {

            double totalTax = 0;
            foreach (Transaction transaction in _transactions)
            {
                double taxAmount = transaction.Amount * BusinessInfo.TaxAmount;
                totalTax += taxAmount;
            }
            return totalTax;


        }
        public static double CalculateTotal()
        {
            double total = 0;
            foreach (Transaction transaction in _transactions)
            {
                total += transaction.Amount;
            }
            return total * (1 + BusinessInfo.TaxAmount);



        }
    }


}
