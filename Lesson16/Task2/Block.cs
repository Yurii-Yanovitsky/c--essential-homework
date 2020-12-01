namespace Task2
{
    class Block
    {
        readonly private int _a;
        readonly private int _b;
        readonly private int _c;
        readonly private int _d;

        public Block(int a, int b, int c, int d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && this.GetType() == obj.GetType())
            {
                Block block = (Block)obj;
                return (_a == block._a && _b == block._b && _c == block._c && _d == block._d);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return _a ^ _b ^ _c ^ _d;
        }

        public override string ToString()
        {
            return $"a = {_a}, b = {_b}, c = {_c}, d = {_d}";
        }
    }
}
