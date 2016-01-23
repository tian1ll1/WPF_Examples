using System;
using System.Collections.Generic;
using System.Text;


namespace BetterAddHatAndBehavior
{
    class Person
    {
        private List<Behavior> _MyBehavior = new List<Behavior>();

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
        { 
            this._MyBehavior.Add(new Swimming());
            this._MyBehavior.Add(new PlayTennis());
        }

        public Person(string name) : this()
        {
            _PersonName = name;    
        }

        public void Play(string name)
        {
            foreach (Behavior b in this._MyBehavior)
            {
                if (b.BehaviorName.Equals(name))
                {                   
                    b.Execute();
                    break;
                }
            }
        }

        //public void PlayTennis()
        //{ }
    }
}
