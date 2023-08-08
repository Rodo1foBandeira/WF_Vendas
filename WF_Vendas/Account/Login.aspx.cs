using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WF_Vendas.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("hahaha"); // Dmnd01
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                Console.WriteLine(returnUrl); // Dmnd01
                Console.WriteLine("?ReturnUrl=" + returnUrl); // Dmnd02
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
            Console.WriteLine("Log 1"); // dmnd01

            Console.WriteLine("Log 1111"); // DMND02
        }
    }
}