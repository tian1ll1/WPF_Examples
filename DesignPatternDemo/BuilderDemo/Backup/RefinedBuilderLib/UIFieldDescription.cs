using System;
using System.Collections.Generic;
using System.Text;

namespace RefinedBuilderLib
{
   public class UIFieldDescription
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _DisplayType;

        public string DisplayType
        {
            get { return _DisplayType; }
            set { _DisplayType = value; }
        }

        private string _DisplayField;

        public string DisplayField
        {
            get { return _DisplayField; }
            set { _DisplayField = value; }
        }

        private string _ValueField;

        public string ValueField
        {
            get { return _ValueField; }
            set { _ValueField = value; }
        }

       public UIFieldDescription(string name, string displayType, string displayField, string valueField)
       {
           this._Name = name;
           this._DisplayType = displayType;
           this._DisplayField = displayField;
           this._ValueField = valueField;
       }
       
    }
}
