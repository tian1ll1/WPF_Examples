using System;
using System.Collections.Generic;
using System.Text;

namespace FirstPattern
{
    class Hat
    {
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
}
