<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetRegion.aspx.cs" Inherits="Wuyiju.Web.users.GetRegion" %>

<% foreach (var item in regions)
    { %>
<option value="<%=item.Region_Id %>"><%=item.Region_Name %></option>
<%} %>