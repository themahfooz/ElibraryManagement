<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminauthormanagement.aspx.cs" Inherits="ElibraryManagement.adminauthormanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author Details</h4>
                                </center>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="imgs/writer.png" />
                                </center>
                            </div>
                        </div>

                        <br />

                        <div class="row">
                            <div class="col-md-3">
                                 <label>Author ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                    <asp:TextBox class="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="GO" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-9">
                                 <label>Author Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Author Name"></asp:TextBox>
                                </div>
                            </div>
                        </div><br />
                        
                        <div class="row">
                            <div class="col-4 ">
                                    <asp:Button class="btn btn-success w-100 btn-lg" ID="Button2" runat="server" Text="Add" />
                            </div>
                            <div class="col-4 ">
                                    <asp:Button class="btn btn-primary w-100 btn-lg" ID="Button3" runat="server" Text="Update" />
                            </div>
                            <div class="col-4 ">
                                    <asp:Button class="btn btn-danger w-100 btn-lg" ID="Button4" runat="server" Text="Delete" />
                            </div>
                        </div>
                    </div>
                <a href="homepage.aspx"> << Back to Home</a><br /><br />
            </div>
          </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author List</h4>
                                </center>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col">
                                <asp:GridView class="table table-striped" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>

                        <br />

                       
              </div>
            </div>
          </div>
        </div>
    </div>
</asp:Content>
