using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace RefinedBuilderLib
{
    public class WebBuilder : UIBuilder
    {
        private Panel _Panel = null;        
        private int _ControlWidth = 60;
        private int _ControlHeight = 20;

        public WebBuilder()
        {
            this._Panel = new Panel();
        }

        public override void AddNewLine()
        {
            Literal lit = new Literal();
            lit.Text = "<br/>";
            this._Panel.Controls.Add(lit);
        }

        public override void AddLabel(string title)
        {
            Label lbl = new Label();
            lbl.Text = title;            
            lbl.Width = _ControlWidth;
            lbl.Height = _ControlHeight;

            _Panel.Controls.Add(lbl);
        }

        public override void AddTextBox(string valueField)
        {
            TextBox txb = new TextBox();
            txb.Text = valueField; //实际应用中应该用该ValueField到数据库中取数据。           
            txb.Width = _ControlWidth * 3;
            txb.Height = _ControlHeight;

            _Panel.Controls.Add(txb);
        }

        public override void AddCombox(string dispalyField, string valueField)
        {
            DropDownList ddlist = new DropDownList();
            ddlist.DataTextField = dispalyField;//实际应用中应该用该ValueField和displayField到数据库中取数据。
            ddlist.DataValueField = valueField;

            ddlist.Width = _ControlWidth;
            ddlist.Height = _ControlHeight;

            _Panel.Controls.Add(ddlist);
        }

        public override void AddButton(string title, string key)
        {
            Button btn = new Button();
            btn.Text = title;                      
            btn.Width = _ControlWidth;
            btn.Height = _ControlHeight;

            _Panel.Controls.Add(btn);
        }

        public Panel GetUI()
        {
            return _Panel;
        }
    }
}
