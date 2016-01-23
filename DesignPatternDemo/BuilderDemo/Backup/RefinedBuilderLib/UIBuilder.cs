using System;
using System.Collections.Generic;
using System.Text;

namespace RefinedBuilderLib
{
   public abstract class UIBuilder
    {
       public abstract void AddNewLine();
       public abstract void AddLabel(string title);
       public abstract void AddTextBox(string valueField);
       public abstract void AddCombox(string dispalyField, string valueField);
       public abstract void AddButton(string title, string key);

    }
}
