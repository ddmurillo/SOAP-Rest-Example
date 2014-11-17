using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapRestWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                result.Attributes["disabled"] = "disabled";
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = new SoapMathSvcReference.MathClient().Suma(Convert.ToInt32(val1.Text), Convert.ToInt32(val2.Text)).ToString();
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert",
                    string.Format("alert('{0}');", "Ha ocurrido un error inesperado"), true);
            }
        }
    }
}
