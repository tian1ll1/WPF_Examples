using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using RefinedBuilderLib;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WebBuilder web = new WebBuilder();
        List<UIFieldDescription> controlDesc = new List<UIFieldDescription>();
        controlDesc.Add(new UIFieldDescription("姓名", "ｔext", "FullName", "FullName"));
        controlDesc.Add(new UIFieldDescription("性别", "select", "Gender", "Gender"));
        controlDesc.Add(new UIFieldDescription("住址", "text", "Address", "Address"));
        controlDesc.Add(new UIFieldDescription("Age", "text", "Age", "Age"));
        controlDesc.Add(new UIFieldDescription("Email", "text", "Email", "Email"));

        UIDirector director = new UIDirector(web);
        director.Build(controlDesc);

        Panel p = web.GetUI();

        foreach (Control ctl in this.Controls)
        {
            if (ctl is HtmlForm)
            { 
                ctl.Controls.Add(p);
                break;
            }
        }
        
    }
}
