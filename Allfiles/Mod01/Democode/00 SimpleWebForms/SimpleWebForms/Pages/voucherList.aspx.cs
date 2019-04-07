using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleWebForms
{
    public partial class voucherList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RowSelected(object sender, EventArgs e)
        {
            GridViewRow row = gvVouchers.SelectedRow;

            foreach (TableCell cell in row.Cells)
            {
                Debug.WriteLine(cell.Text);
            }

            var id = gvVouchers.SelectedDataKey?.Value; //gvVouchers.SelectedDataKey !=null ? gvVouchers.SelectedDataKey.Value : null;

            if (id!=null)
            {
                Response.Redirect($"~/Pages/voucherDetails.aspx?ID={id}");
            }
        }
    }
}