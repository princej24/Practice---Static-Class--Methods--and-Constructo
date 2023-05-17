using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp1 
{
    public class Transaction
    {
        private DateTime _now = DateTime.Now;
        private string _name;
        private double _amount;

        public Transaction(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }

        public string Name => _name;
        public double Amount => _amount;

        public override string ToString()
        {
            return $"{_name} - {_now.ToShortDateString()} - {_amount.ToString("c")}";
        }
    }
}
