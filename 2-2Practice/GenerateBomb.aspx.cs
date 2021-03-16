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
            int[,] Bomb = new int[10,10];
            int[] input = { 0, 7, 13, 28, 38, 42, 50, 62, 87, 90 };
            int r, c;
            
            for (r = 0; r < 10; r++) {
                for (c = 0; c < 10; c++) {
                    Bomb[r,c]=value(r,c,input);
                }
            }

            for (r = 0; r < 10; r++) {
                for (c = 0; c < 10; c++) {

                    if (Bomb[r, c] == 88 && r != 0 && c != 9 && c != 0 && r != 9) {

                        for (int i = r - 1; i <= r + 1; i++) {
                            for (int j = c - 1; j <= c + 1; j++) {
                                if (Bomb[i, j] != 88)
                                    Bomb[i, j] += 1;
                            }
                        }
                    }
                    
                }
                
            }
            


            Response.Write("<table border='1' style='text-align:center;' >");
            for (r = 0; r < 10; r++)
            {
                Response.Write("<tr>");
                for (c = 0; c < 10; c++)
                {
                    Response.Write("<td style='width:20px; height:20px';>");
                    Response.Write(Bomb[r, c].ToString() + "</td>");
                }
                Response.Write("</tr>");
            }
            Response.Write("</table>");
        }
    }
}