using System;

namespace Task4
{
    class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;
        private readonly double _ndcKoef;

        public Invoice(int account, string customer, string provider, double ndcKoef)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
            _ndcKoef = ndcKoef;
        }

        public Invoice()
        {
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
