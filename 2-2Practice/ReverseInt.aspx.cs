using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class ReverseInt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 12;
            int g = 0;
            string s = "";
            /*
             1254   125 12  2    4521
             */
            if (0 <= num && num <= 100000)
            {
                while (num != 0)
                {
                    g = num % 10;
                    num = num / 10;
                    s += g.ToString();
                }
                
            }
            else
            {
                Response.Write("Number is not between 0 and 100000");
            }
            Response.Write(s);
        }
    }
}