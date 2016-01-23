using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RefinedBuilderLib
{
    public class WinBuilder : UIBuilder
    {
        private Panel _Panel = null;
        private int _ControlTop;
        private int _ControlLeft;
        private int _ControlWidth = 60;
        private int _ControlHeight = 20; 
        private int _NewLineHeight = 10;

        public WinBuilder()
        {
            _Panel = new Panel();
            _ControlTop = 10;
            _ControlLeft = 10;
        }

        public override void AddNewLine()
        {
            _ControlTop = _ControlTop + _ControlHeight + _NewLineHeight;
            _ControlLeft = 10;
        }

        public override void AddLabel(string title)
        {
            Label lbl = new Label();
            lbl.Text = title;
            lbl.Top = _ControlTop;
            lbl.Left = _ControlLeft;
            lbl.Width = _ControlWidth;
            lbl.Height = _ControlHeight;
          
            _Panel.Controls.Add(lbl);

            _ControlLeft = _ControlLeft + lbl.Width + _NewLineHeight;
        }

        public override void AddTextBox(string valueField)
        {
            TextBox txb = new TextBox();
            txb.Text = valueField; //ʵ��Ӧ����Ӧ���ø�ValueField�����ݿ���ȡ���ݡ�
            txb.Top = _ControlTop;
            txb.Left = _ControlLeft;
            txb.Width = _ControlWidth * 3;
            txb.Height = _ControlHeight;

            _Panel.Controls.Add(txb);

            _ControlLeft = _ControlLeft + txb.Width + _NewLineHeight;
        }

        public override void AddCombox(string dispalyField, string valueField)
        {
            ComboBox cmb = new ComboBox();
            cmb.DisplayMember = dispalyField;//ʵ��Ӧ����Ӧ���ø�ValueField��displayField�����ݿ���ȡ���ݡ�
            cmb.ValueMember = valueField;
            cmb.Top = _ControlTop;
            cmb.Left = _ControlLeft;
            cmb.Width = _ControlWidth * 3;
            cmb.Height = _ControlHeight;

            _Panel.Controls.Add(cmb);

            _ControlLeft = _ControlLeft + cmb.Width + _NewLineHeight;
        }

        public override void AddButton(string title, string key)
        {
            Button btn = new Button();
            btn.Text = title;
            btn.Tag = key;
            btn.Top = _ControlTop;
            btn.Left = _ControlLeft;
            btn.Width = _ControlWidth;
            btn.Height = _ControlHeight;

            _Panel.Controls.Add(btn);

            _ControlLeft = _ControlLeft + btn.Width + _NewLineHeight;
        }

        public Panel GetUI()
        {
            return this._Panel;
        }
    }
}
