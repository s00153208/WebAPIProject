<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyHotels.aspx.cs" Inherits="WebAPI.MyHotels" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Your hotels</h2>

    <asp:SqlDataSource ID="SqlDataSourceHotels" runat="server" ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' SelectCommand="SELECT [Id], [Name], [Address], [City], [County], [Phone], [UserId] FROM [Hotels]"></asp:SqlDataSource>

    <div class="row">
        <div class="col-md-9">
            <table class="table table-hover">
                <thead class="thead-inverse">
                    <tr>
                        <th>#</th>
                        <th>Name</th>
                        <th>City</th>
                        <th>County</th>
                        <th>Address</th>
                        <th>Phone</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="myRepeater" runat="server" DataSourceID="SqlDataSourceHotels">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><%# Eval("Id")%></th>
                                <td><%# Eval("Name")%></td>
                                <td><%# Eval("City")%></td>
                                <td><%# Eval("County")%></td>
                                <td><%# Eval("Address")%></td>
                                <td><%# Eval("Phone")%></td>
                                <td>
                                    <a class="blue-text"><span class="glyphicon glyphicon-pencil" aria-hidden="true"></span></a>
                                    <a class="red-text"><span class="glyphicon glyphicon-remove" aria-hidden="true"></span></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
        <div class="col-md-3 text-center">
            <a href="AddHotel.aspx" class="btn btn-primary btn-lg" role="button">Register hotel</a>
        </div>
    </div>


</asp:Content>
