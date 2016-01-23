using System;
using System.Collections.Generic;
using System.Text;

namespace RefinedBuilderLib
{
    public class UIDirector
    {
        private UIBuilder builder;

        public UIDirector(UIBuilder b)
        {
            this.builder = b;
        }

        public void Build(List<UIFieldDescription> fields)
        {
            foreach (UIFieldDescription field in fields)
            {
                this.builder.AddLabel(field.Name);

                switch (field.DisplayType)
                { 
                    case "text" :
                        this.builder.AddTextBox(field.ValueField);
                        break;
                    case "select":
                        this.builder.AddCombox(field.DisplayType, field.ValueField);
                        break;
                }

                this.builder.AddNewLine();

            }

            this.builder.AddButton("添加", "add");
            this.builder.AddButton("修改", "update");
            this.builder.AddButton("删除", "delete");
            this.builder.AddButton("取消", "cancel");

        }
    }
}
