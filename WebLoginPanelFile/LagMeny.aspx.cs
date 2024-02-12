using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebLoginPanelFile
{
    public partial class LagMeny : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxPassWord.Text == "123")
                Panel1.Visible = true;
        }

        protected void ButtonLagreMeny_Click(object sender, EventArgs e)
        {
            string filePath=Path.GetFullPath("meny.txt");
            string filePathAbs = Server.MapPath("meny.txt");
            //hente ut alle 5 verdier i tekstbokser
            string mandag = TextBox1.Text;
            string tirsdag = TextBox2.Text;
            string onsdag = TextBox3.Text;

            //sånn, alt er hentet, nå lagre. til feks en fil
            File.WriteAllText(filePathAbs, mandag+"#"+tirsdag+"#"+onsdag+"#");
        }
    }
}