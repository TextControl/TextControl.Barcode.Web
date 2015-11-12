using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcode
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // set the barcode text
            string sBarcodeText = DateTime.Now.Ticks.ToString();

            // set the URL to the ASPX page that returns the image data
            Barcode1.ImageUrl = "CreateBarcode.aspx?text=" + sBarcodeText;
            lblBarcodeText.Text = sBarcodeText;
        }
    }
}