namespace Task3
{
    class Model
    {
        private int x;
        public string Tick()
        {
            x++;
            return x >= 60 ? $"{(x / 60)} мин {x % 60} сек" : $"{0} мин {x} сек";
        }
        public void Reset()
        {
            x = 0;
        }
    }
}
