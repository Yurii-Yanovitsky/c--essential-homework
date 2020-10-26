using System;

namespace AdditionalTask
{
    class User
    {
        public readonly DateTime _date;
        private int _age;

        public User(string login, string name, string lastName, int age)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
            _date = DateTime.Now;
        }

        public string Login { get; }
        public string Name { get; }
        public string LastName { get; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value >= 18)
                {
                    _age = value;
                }
                else
                {
                    _age = 18;
                }
            }
        }

    }
}
