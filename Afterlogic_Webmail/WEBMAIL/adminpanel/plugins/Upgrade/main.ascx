﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="main.ascx.cs" Inherits="PlugIns_Upgrade_main" %>
<div style="background-color:#fff;">
<table class="wm_settings">
	<tr>
		<td class="wm_settings_cont" valign="top" id="center_tables">
		
<style>
    .purchase-b div {
	    background:#F2983D;
	    background-image:url(images/purchase.png);
    }
    .get-it-b div {
	    background-color:#58BF4F;
	    background-image:url(images/get-it.png);
    }
a:hover {
	cursor:pointer;
}
.a, .b {
	height:1px;
	overflow:hidden;
	padding:0px !important;
}
.a {
	margin: 0px 2px;
}
.b {
	margin: 0px 1px;
}
.features-block, .compare-block {
	/*margin:8px 20px 8px 20px;*/
}
.features-block h2 {
	padding: 16px 12px 10px;
	font-family: Tahoma,Arial,Helvetica,sans-serif;
	font-size:13px
}
.compare-block {
	width:485px;
}
.compare-block h2 {
	padding: 10px 12px 0px;
	font-family: Tahoma,Arial,Helvetica,sans-serif;
	font-size:13px
}
.compare-header h2 {
	padding:10px 20px!important;
	margin:0px !important;
	border-left:1px solid #ddd;
	border-right:1px solid #ddd;
	border-bottom:1px solid #ddd;
	font-size:12px;
}
.compare-item {padding:12px 20px 4px; border-left:1px solid #ddd; border-right:1px solid #ddd;}
.compare-item div {float:left; /*width:482px;*/ width:318px; padding:4px 0px 4px 6px; }
.compare-item span {border-bottom:1px solid #eee; display:block;padding:0px 0px 4px;}
.compare-item img {margin:0px 15px 0px 18px;}
.compare-item.bottom span {border:none;}
.maindivclass {
	background: #ffffe1;
	width:445px;
	font-family: Tahoma,Arial,Helvetica,sans-serif;
	padding: 20px 20px;
	font-size: 13px;
}
/*buttons*/
.button_link {
	font-family:Verdana,sans-serif;
	font-weight:bold !important;
	display:block;
	font-size:12px;
	color:#fff !important;
	text-decoration:none !important;
	margin:0px 20px 0px 0px;
	line-height:22px;
	float: left;
}
.button_link div {
	padding:4px 10px;
	background-position:top;
	height:26px; width:84px;
	text-align: center;
}
.button_link:hover div {
	background-position:bottom;
}
.button_link div.a {
	padding: 0px;
}
</style>
<asp:PlaceHolder ID="UpgradeContent" runat="server"></asp:PlaceHolder>