using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleWebForms.Models;

namespace SimpleWebForms.Pages
{
    public partial class voucherDetails : System.Web.UI.Page
    {
        private Guid currentVoucherID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                if (Request.QueryString["ID"]!=null)
                {
                    currentVoucherID = new Guid(Request.QueryString["ID"]);
                    var v = VouchersRepository.GetVoucher(currentVoucherID);
                    if (v!=null)
                    {
                        txtVoucherText.Text = v.Text;
                        txtDate.Text = v.Date.ToString("dd.MM.yyyy");
                        rblType.SelectedIndex = v.Type;
                        chkPaid.Checked = v.Paid;
                    }
                }
            }
        }
        
        protected void lbAdd_Click(object sender, EventArgs e)
        {
            VoucherDetail vd = new VoucherDetail
            {
                ID = Guid.NewGuid(),
                Text = txtVDText.Text,
                Amount = string.IsNullOrEmpty(txtVDAmount.Text) == false ? decimal.Parse(txtVDAmount.Text) : 0,
                AccountID = new Guid(ddAccount.SelectedValue),
                Comment = txtComment.Text,
                VoucherID = new Guid(Request.QueryString["ID"])
            };
            VouchersRepository.AddDetail(vd);
            gvVoucherDetails.DataBind();
            
        }

        protected void detailChanged(object sender, EventArgs e)
        {
            string id = gvVoucherDetails.SelectedDataKey?.Value.ToString();
            var vd = VouchersRepository.GetVoucherDetail(new Guid(id));
            if (vd != null)
            {
                txtVDText.Text = vd.Text;
                txtVDAmount.Text = vd.Amount.ToString();
                txtComment.Text = vd.Comment;
                ddAccount.SelectedValue = vd.AccountID.ToString();

            }
        }
    }
}