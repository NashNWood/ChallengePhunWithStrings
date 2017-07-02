using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1. Reverse your name
            /*string name = "Nash Wood";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }
            */

            //2. Reverse this sequence
            string names = "Luke,Leia,Han,Chewbacca";
            string result = "";
            string[] rebelScum = names.Split(',');
            /*for (int j = rebelScum.Length - 1; j >= 0; j--)
            {
                result += rebelScum[j] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
            */

            // 3.Use the sequence to create ascii art



        }


        

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }

        
    }
