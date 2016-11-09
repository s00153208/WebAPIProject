<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddHotel.aspx.cs" Inherits="WebAPI.AddHotel" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">

        <div class="col-md-6">
            <form method="post">
                <h2>Hotel creation</h2>
                <br />
                <div class="md-form">
                    <i class="fa fa-address-card-o prefix"></i>
                    <input type="text" id="hotelName" class="form-control" name="hotelName">
                    <label for="hotelName">Hotel name</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-map prefix"></i>
                    <input type="text" id="hotelAddress" class="form-control" name="hotelAddress">
                    <label for="hotelAddress">Address</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-map prefix"></i>
                    <input type="text" id="hotelCounty" class="form-control" name="hotelCounty">
                    <label for="hotelCounty">County</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-map prefix"></i>
                    <input type="text" id="hotelCity" class="form-control" name="hotelCity">
                    <label for="hotelCity">City</label>
                </div>
                <div class="md-form">
                    <i class="fa fa-phone prefix"></i>
                    <input type="text" id="hotelPhone" class="form-control" name="hotelPhone">
                    <label for="hotelPhone">Phone</label>
                </div>

                <a href="MyHotels.aspx"><input type="button" class="btn btn-warning" value="Back to My Hotels"/></a>
                <input type="submit" class="btn btn-primary" value="Register new Hotel"/>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </form>
        </div>

    </div>



</asp:Content>
