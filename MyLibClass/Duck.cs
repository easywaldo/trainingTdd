using System;

namespace Animals
{
    public class Duck
    {
        private string _name;

        public Duck(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}
