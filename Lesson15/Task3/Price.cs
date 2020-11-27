namespace Task3
{
    struct Price
    {
        public string ProductName { get; private set; }
        public string Shop { get; private set; }
        public int Cost { get; set; }

        public Price(string productName, string shop, int cost)
        {
            ProductName = productName;
            Cost = cost;
            Shop = shop;
        }

        public override string ToString()
        {
            return $"Товар: {ProductName}, Магазин: {Shop}, Цена: {Cost}";
        }
    }
}
