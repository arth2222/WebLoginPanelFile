using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebLoginPanelFile
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //her må vi lese fra filen, som inneholder meny

            string filePathAbs = Server.MapPath("meny.txt");
            string fileContent=File.ReadAllText(filePathAbs);

            //splitte teksten, som da lager en array med 5 elementer. En per dag.
            string[] splitArray = fileContent.Split('#');

            //gi labelene hver sin "verdi" fra arrayen

            LabelMandag.Text = splitArray[0];
            //gjenta
        }
    }
}