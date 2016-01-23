using System;
using System.Collections.Generic;
using System.Text;

namespace BetterAddHatAndBehavior
{
    class Hat
    {
        public Hat()
        { }

        private string _HatType = string.Empty;

        public string HatType
        {
            get { return _HatType; }
            set { _HatType = value; }
        }

        public Hat(string hatType)
        {
            this._HatType = hatType;
        }
    }

    class TennisHat : Hat
    {

    }

    class SwimmingHat : Hat
    {

    }
}
