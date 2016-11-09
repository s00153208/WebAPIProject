using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPI.Models;

namespace WebAPI
{
    public partial class MyHotels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.User != null && this.User.Identity.IsAuthenticated)
            {

                ApplicationDbContext ctx = new ApplicationDbContext();
                string currentUserId = User.Identity.GetUserId();
                var hotels = (from h in ctx.Hotel
                              where h.UserId == currentUserId
                              orderby h.Name
                              select h).ToList();
            }else
                Response.Redirect("~/Default");
        }
    }
}