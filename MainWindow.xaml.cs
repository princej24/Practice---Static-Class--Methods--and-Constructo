using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DisplayAllInfo();
        }

        private void DisplayAllInfo()
        {
            MessageBox.Show($"*prince's hype spot*\n\nYour purchases were:\n\n" +
                $"adidas blue back pack - {DailyTransactions.Transactions[0].ToString()}\n" +
                $"comme des garcons - {DailyTransactions.Transactions[1].ToString()}\n" +
                $"vans VALENTINES TALL CUFF BEANIE - {DailyTransactions.Transactions[2].ToString()}\n" +
                $"Chuck 70 AT-CX Colorblock - {DailyTransactions.Transactions[3].ToString()}\n" +
                $"Chuck Taylor All Star Black Joy - {DailyTransactions.Transactions[4].ToString()}\n\n" +
                 $"Tax rate: {BusinessInfo.TaxRate * 100}%\n" +
                // $"Tax amount: {taxAmount.ToString("c")}\n\n" +
              //  $"Tax is {BusinessInfo.TaxAmount}\n\n" +
                $"{DailyTransactions.taxTotal().ToString("c")}\n\n" +
                $"The total was: {DailyTransactions.CalculateTotal().ToString("c")}") ;
        }

       
    }
}
