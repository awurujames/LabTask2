using System;
namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            Console.Write("Please enter your quantity: ");
            invoice.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Select price: ");
            invoice.Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Your quantity is {invoice.Quantity} and your price is {invoice.Price} total: {invoice.GetInvoiceAmount():C}");
        }
    }
}