using System;

namespace Task4
{
    class Invoice
    {
        public readonly int _account;
        public readonly string _customer;
        public readonly string _provider;
        public readonly double _ndcKoef;

        public Invoice(int account, string customer, string provider, double ndcKoef)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
            _ndcKoef = ndcKoef;
        }

        public string Article { get; set; }
        public int Quantity { get; set; }
        public double UnitCost { get; set; }

        public void CalculatePaymenAmount(bool isNdc)
        {
            if (isNdc)
            {
                Console.WriteLine($"Payment amount: {UnitCost * Quantity + UnitCost * Quantity * _ndcKoef}$");
            }
            else
            {
                Console.WriteLine($"Payment amount: {UnitCost * Quantity}$");
            }
        }




    }
}
