using System;
using System.Collections.Generic;
using System.Text;

namespace FirstPattern
{
    class Person
    {
        private string _PersonName = string.Empty;
        private Hat _MyHat = null;

        public string PersonName
        {
            get { return _PersonName; }
            set { _PersonName = value; }
        }
        
        public Hat MyHat
        {
            get { return _MyHat; }
            set { _MyHat = value; }
        }

        public Person(string name)
        {
            _PersonName = name;    
        }

        public void PlayTennis()
        { }
    }
}
