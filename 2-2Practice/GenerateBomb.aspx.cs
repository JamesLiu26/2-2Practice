using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[,] Bomb = new string[10,10];
            int[] input = { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int r, c;

            for (r = 0; r < 10; r++)
            {
                for (c = 0; c < 10; c++)
                {
                    Response.Write("O");
                    int num = r * 10 + c;

                    for (int i = 0; i < 10; i++)
                    {
                        if (num == input[i])
                        {
                            Response.Write("●");
                        }
                    }
                    Response.Write(Bomb[r, c]);
                }
                Response.Write("<br/>");
            }



        }
    }
}