using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Collections.Specialized;
using System.Text;

using System.Drawing;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace ThirdDatabaseHandin
{
    public partial class Index : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            ImagePoster.ImageUrl = "~/Files/Avatar.png";
        }

        protected void BtnMovie_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string result = client.DownloadString("http://localhost:" + TextBoxPort.Text + "/api/values/" + TextBoxName.Text);

            result = result.Replace(@"\", "");
            // result = result.Substring(1, result.Length - 2);

            File.WriteAllText(Server.MapPath("~/Files/LatestResult.json"), result);
            LabelFileMade.Text = "Succeded In Making Json File";

            string[] seperatingChars = { "\":\"", "\",\"", "\":[{\"", "\"},{\"", "\"}]\"", "{\"", "\"}" };
            string[] mysplit = result.Split(seperatingChars, System.StringSplitOptions.RemoveEmptyEntries);

  

            if (mysplit[1] != "False")
            {
                LabelMessage.Text = mysplit.Length.ToString();
                TextBoxResult.Text = result;

                for (int i = 0; i < mysplit.Length; i++)
                {
                    if (mysplit[i] == "Poster")
                    {
                        ImagePoster.ImageUrl = mysplit[++i];
                        if(ImagePoster == null)
                        {
                            ImagePoster.ImageUrl = "~/Files/Avatar.png";
                        }
                        break;
                    }
                }
                LabelResult.Text = "Ratings ";
                for (int i = 0; i < mysplit.Length; i++)
                {
                    if (mysplit[i] == "Ratings")
                    {
                        while (mysplit[++i] == "Source")
                        {
                            if (mysplit[i - 1] != "Ratings") LabelResult.Text += "; ";
                            LabelResult.Text += mysplit[i + 3] + " From " + mysplit[i + 1];
                        }
                        i = i + 3;
                        break;
                    }

                }
            }
            else
            {
                LabelMessage.Text = "Something went wrong";
            }
        }
    }
}