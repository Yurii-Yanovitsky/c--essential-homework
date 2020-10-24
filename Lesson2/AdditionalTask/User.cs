using System;

namespace AdditionalTask
{
    class User
    {
        public readonly DateTime _date;
        private int _age;

        public User()
        {
            _date = DateTime.Now;
        }

        public User(string login, string name, string lastName, int age)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
            _date = DateTime.Now;
        }

        public string Login { get; } = "No Login";
        public string Name { get; } = "No Name";
        public string LastName { get; } = "No LastName";
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
