using System;

namespace Task3
{
    class Street : ICloneable
    {
        public Street(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
