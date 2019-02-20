<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Async="true" Inherits="WebApplication1._Default" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h2>Vote</h2>
    </div>

    <div class="row">
        <div class="col-md-3">
            <h2>Users to Vote</h2>
            <p>
                <asp:DropDownList ID="ddlUser"  CssClass="form-control btn-info"  EnableViewState="true"   runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlUser_SelectedIndexChanged" >
                    <asp:ListItem Text="-- Please Select Users --" Value="0" />
                    <asp:ListItem Text="User 1" Value="0x71d54D727F333e73Dc15F0abaF4C738C7f2b7C89" />
                    <asp:ListItem Text="user 2" Value="0xEe5468Aefb6ce3C6b9f207b675B9e0a69Ce3D285"/>
                    <asp:ListItem Text="user 3" Value="0xAa7d85bc5f5cA97F70Dd26D5AFB37ad52Bbb9FD2"/>
                    <asp:ListItem Text="user 4" Value="0xd3A853492D93d476f1C8f22939De47B761B0bFa6"/>
                    <asp:ListItem Text="User 5" Value="0x186aADa08e645d20860D902158BD789c4f8f2548" />
                    <asp:ListItem Text="user 6" Value="0xDc25245A65cCE2aA04b2c3D35078370096045B50"/>
                    <asp:ListItem Text="user 7" Value="0x6C192DDFE459e02ED43bf289D301AB227EA82DbF"/>
                    <asp:ListItem Text="user 8" Value="0x8BE3477B937984cc58E1122db926e9f13159f237"/>
                    <asp:ListItem Text="user 9" Value="0xF7C3Aa8c062E7a536d8Cb94Aa7FA511319617361"/>
                    <asp:ListItem Text="user 10" Value="0x42b7976Db1920f21ce495bFFf5114ff687B6d24F"/>
                </asp:DropDownList>
            </p>
           
            <h2>Available votes</h2>
            <p>
                <asp:DropDownList ID="ddlVotesAvailable" AutoPostBack="true" EnableViewState="true" OnSelectedIndexChanged="ddlVotesAvailable_SelectedIndexChanged" CssClass="form-control btn-success" runat="server" >
                    <asp:ListItem Text="-- Please Select Option --" Value="0" />
                    <asp:ListItem Text="Best Technology" Value="0x15997d38B375ebCB234c458Dd6771B43A0120ba5" />
                    <asp:ListItem Text="Best Political leader"  Value="0xdd18AAdc1467586148A8aa3515F4091EDa07B6c1"/>
                   <asp:ListItem Text="Best Cloud Provider"  Value="0xE14f047Df9a5ec04967cB60a309241aE3a91e967" />
                    <asp:ListItem Text ="Best Movie 2017" Value ="1" />

                </asp:DropDownList>
           
            </p>
        </div>
        <div class="col-md-3">
             <h2>Options For Votes</h2>
           
            <div>
                <div >
			                
                <asp:RadioButtonList ID="rblVoteOptions" CssClass="alert-info" RepeatDirection="Vertical" RepeatLayout="Flow"   runat="server">
                    
                </asp:RadioButtonList>
                
            </div>
                </div>
            <div>
                <asp:Button Text="Cast Option" ID="btnCast" CssClass="btn btn-primary text-right" Visible="false" OnClick="btnCast_Click" runat="server" />
            </div>
        </div>
        <div class="col-md-3">
            <h2>View Result</h2>
             <div>
                <asp:Button Text="View Result" Visible="false" ID="btnViewResult" CssClass="btn btn-primary text-right" OnClick="btnViewResult_Click" runat="server" />
            </div>
            
            
        </div>
        <div class="col-md-3">
            <h2>Result </h2>
            <div visible="false"  class="alert alert-info" runat="server" id="divResult">
                
                    
            
                 </div>
            <div  runat="server">
                  <asp:Chart ID="Chart1" runat="server">
                    <Series>
                        <asp:Series Name="Series1" XValueMember="1" YValueMembers="0">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </div>
         
            
        

    </div>
    
    <div class="row">
        <div class ="col-md-12">
            <asp:Button Text="Clean Info" Visible="false" CssClass="btn btn-primary text-right" ID="btnCleanInfo"  OnClick="btnCleanInfo_Click" runat="server" />
            <div visible="false"  class="alert alert-info" runat="server" id="divInfor">
                     </div>
                    
            
            </div>
        </div> 
        <div class="row">
            
            <div class ="col-md-12">
                <asp:Button Text="Clean Error" Visible="false" CssClass="btn btn-primary float-right"  ID="btnCleanError"  OnClick="btnCleanError_Click" runat="server" />
                <div visible="false" class="alert alert-warning" runat="server" id="divError">
                    
                </div>
                </div>
        </div>

    

    </div>
</asp:Content>
