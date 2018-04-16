<%@ Page Title="" Language="C#" MasterPageFile="~/yönetici.Master" AutoEventWireup="true" CodeBehind="anket.aspx.cs" Inherits="anketUygula.anket1" %>
<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent3" runat="server">
    <div align="center">
        <asp:Label ID="Label1" runat="server" Text="ANKET OLUŞTUR" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <table class="nav-justified" style="width: 82%">
            <tr>
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="width: 439px; height: 49px;">
                    <input type="text" name='baslik'  placeholder='Anket Başlığı' class="form-control"  aria-multiline="True"  />
                </td>
            </tr>
            <tr>
                <td style="height: 69px; width: 128px">
                    <asp:Label ID="Label6" runat="server" Text="Anket Bitiş Tarihi "></asp:Label>
                    <asp:Calendar ID="Calendar2" runat="server" Width="286px" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
                </td>
                <td style="width: 439px; height: 69px">
                    
                   <br />
                    &nbsp;<br />
                    <br />
                    <br />
                    </td>
                
                <td style="height: 69px">

                    </td>
            </tr>
            <tr>

                <td style="width: 128px">

                    <asp:Label ID="labeltarih" runat="server" Text="Label" Visible="False"></asp:Label>

                </td>
                <td>

                    &nbsp;</td>
            </tr>
        </table>

<link href="//netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.3/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<div class="container">
    <div class="row clearfix">
		<div class="col-md-12 column">
			<table class="table table-bordered table-hover" id="tab_logic">
				<thead>
					<tr >
						<th class="text-center">
							#
						</th>
						<th class="text-center">
                            Soru Biçimi Seçiniz :&nbsp;
                            <select id="soruekle" onselect="GetSelectedTextValue(this)" name="D1">
    <option value="0"></option>
    <option value="1">Çoklu Seçim</option>
    <option value="2">Paragraf</option>
    <option value="3">Kısa Yanıt</option>
    <option value="4">Tek Seçim</option>
    <option value="5">Resim</option>
</select></th>
						<th class="text-center">
							Mail
						</th>
						<th class="text-center">
							Mobile
						</th>
					</tr>
				</thead>
				<tbody>
					<tr id='addr0'>
						<td>
						1
						</td>
						<td>
                            &nbsp;</td>
						<td>
						    &nbsp;</td>
						<td>
						&nbsp&nbsp;
                            
						</td>
					</tr>
				</tbody>
			</table>
		</div>
	</div>
	<a id="add_row" class="btn btn-default pull-left">Add Row</a><a id='delete_row' class="pull-right btn btn-default">Soru Sil</a>
</div>
        <div>
            <br /><br /><br />
                        <asp:Button ID="anketkaydet" runat="server" Text="Anket Oluştur" />
        </div>
        
   
    <br />
        <br />
        <br />
 
    </div>
</asp:Content>
