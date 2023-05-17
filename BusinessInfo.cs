using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class BusinessInfo
    {
        private static string _businessName = "*prince's hype spot*";
        private static double _taxRate = 0.1;
        private static double _taxAmount = 0.1;
        public static string BusinessName => _businessName;
        public static double TaxRate => _taxRate;
        public static double TaxAmount => _taxAmount;
       
    }
}
