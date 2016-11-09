using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPI.Models;

namespace WebAPI
{
    public partial class AddHotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                NameValueCollection form = Request.Form;
                var store = new UserStore<ApplicationUser>(new ApplicationDbContext());
                var userManager = new UserManager<ApplicationUser>(store);
                ApplicationUser user = userManager.FindByNameAsync(User.Identity.Name).Result;
                Hotel newEntry = new Hotel
                {
                    Name = form["hotelName"],
                    Address = form["hotelAddress"],
                    City = form["hotelCity"],
                    County = form["hotelCounty"],
                    Phone = form["hotelPhone"],
                    UserId = User.Identity.GetUserId(),
                };

                ApplicationDbContext ctx = new ApplicationDbContext();

                try
                {
                    ctx.Hotel.Add(newEntry);
                    ctx.SaveChanges();
                    Response.Redirect("~/MyHotels.aspx");
                }
                catch (Exception)
                {
                    Response.Redirect("~/AddHotel.aspx");
                }
            }
        }
    }
}