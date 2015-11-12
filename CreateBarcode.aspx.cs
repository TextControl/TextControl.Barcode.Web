using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace barcode
{
    public partial class CreateBarcode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // create a new TXBarcodeControl
            TXTextControl.Barcode.TXBarcodeControl barcode = new TXTextControl.Barcode.TXBarcodeControl();
            barcode.CreateControl();

            // set the barcode type and size
            barcode.BarcodeType = TXTextControl.Barcode.BarcodeType.MicroPDF;
            barcode.UpperTextLength = 40;
            barcode.Width = 500;

            // set the text from the QueryString
            barcode.Text = Request.QueryString["text"];

            // save the barcode to an image MemoryStream
            MemoryStream stream = new MemoryStream();
            barcode.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Png);

            // send back the image
            Response.Clear();
            Response.ContentType = "image/png";
            Response.BinaryWrite(stream.ToArray());
            Response.Flush();
            Response.Close();
            Response.End();
        }
    }
}