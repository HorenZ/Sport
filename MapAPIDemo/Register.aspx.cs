﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace MapAPIDemo
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                (Master.FindControl("lbHeadText") as Label).Text = "注册";

            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (this.txbUnameRe.Text == "")
            {
                Response.Write("<script type='text/javascript'>alert('请输入信息！')</script>");
                return;
            }

            UserInfo user = new UserInfo();
            user.UserName = this.txbUnameRe.Text.Trim();
            user.Pwd = this.txbPwdRe.Text.Trim();
            user.carNum = this.txbCarNumber.Text.Trim();
            user.phone = this.txbPhoneRe.Text.Trim();
            string Msg = new UserInfoBLL().Register(user);
            if (Msg== "注册失败！"||Msg== "用户名重复！")
            {
                this.lbMsg.Text = Msg;
                return;
            }
            //提示信息并执行跳转
            Response.Write("<script type='text/javascript'>alert('" + Msg + "</br>即将跳转至登录界面！');window.window.location.href='Login.aspx';</script>");
        }
    }
}