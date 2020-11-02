using System;

namespace Task4
{
    class Invoice
    {
        private readonly double _ndcKoef;

        public Invoice(int account, string customer, string provider, string article, int quantity, int unitCost, double ndcKoef)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            Article = article;
            Quantity = quantity;
            UnitCost = unitCost;
            _ndcKoef = ndcKoef;
        }
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }
        public string Article { get; }
        public int Quantity { get; }
        public double UnitCost { get; }

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
