using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string filepath = Server.MapPath("\\Upload");
        HttpFileCollection uploadedFiles = Request.Files;
        Span1.Text = string.Empty;

        for (int i = 0; i < uploadedFiles.Count; i++)
        {
            HttpPostedFile userPostedFile = uploadedFiles[i];

            try
            {
                if (userPostedFile.ContentLength > 0)
                {
                    //Span1.Text += "<u>File #" + (i + 1) + "</u><br>";
                    //Span1.Text += "File Content Type: " + userPostedFile.ContentType + "<br>";
                    //Span1.Text += "File Size: " + userPostedFile.ContentLength + "kb<br>";
                    //Span1.Text += "File Name: " + userPostedFile.FileName + "<br>";

                    //userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(userPostedFile.FileName));
                    //Span1.Text += "Location where saved: " + filepath + "\\" + Path.GetFileName(userPostedFile.FileName) + "<p>";
                    Span1.Text += userPostedFile.FileName + "上傳成功" + "<br>";
                }
            }
            catch (Exception Ex)
            {
                Span1.Text += "Error: <br>" + Ex.Message;
            }
        }
    }
}