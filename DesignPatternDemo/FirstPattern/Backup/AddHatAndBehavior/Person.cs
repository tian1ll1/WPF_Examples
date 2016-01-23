using System;
using System.Collections.Generic;
using System.Text;

namespace AddHatAndBehavior
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

        public Person()
        { }

        public Person(string name)
        {
            _PersonName = name;    
        }

        public void PlayTennis()
        { }
    }

    class SkiPerson : Person
    { }
    class FootballSkiPerson : SkiPerson
    { }
    class TennisFootballSkiPerson : FootballSkiPerson
    { }
}
