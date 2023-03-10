using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sabong.Business;

/// <summary>
/// Summary description for WebUtil
/// </summary>
public class WebUtil
{
	public WebUtil()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static SessionInfo GetSessionInfo()
    {
        var session = SessionContainer.Get(GetUserKey());
        if (session != null)
        {
            session.LastUpdate = DateTime.Now;
            SetCookie("sec", session.SessionId, DateTime.Now.AddDays(7));
            return session;
        }
        return null;
    }

    public static void LogOut()
    {
        SessionContainer.Delete(GetUserKey());
        ExprireCookie("sec");
    }

    public static string GetUserKey()
    {
        try
        {
            return HttpContext.Current.Request.Cookies["sec"].Value;
        }
        catch (Exception)
        {
            return "";
        }

    }

    public static void SetCookie(string name, string value, DateTime exprire)
    {
        var cookies = HttpContext.Current.Response.Cookies;
        var c = new HttpCookie(name, value) { Expires = exprire };

        if (!cookies.AllKeys.Contains(name)) HttpContext.Current.Response.Cookies.Add(c);
        else HttpContext.Current.Response.Cookies.Set(c);
    }

    public static string GetCurrentLang()
    {
        var cookies = HttpContext.Current.Request.Cookies;
        if (cookies["user-lang"]!=null)
        {
            return cookies["user-lang"].Value;
        }
        else
        {
            return string.Empty;
        }
    }

    public static bool IsValidCapChar(string input)
    {
        try
        {
            var sCapchar = HttpContext.Current.Session["CaptchaVerifyCode"].ToString();
            return input == sCapchar;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static void ExprireCookie(string name)
    {
        SetCookie(name, "", DateTime.Now);
    }

    public static string GetIPAddress()
    {
        HttpContext context = HttpContext.Current;
        string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        if (!string.IsNullOrEmpty(ipAddress))
        {
            string[] addresses = ipAddress.Split(',');
            if (addresses.Length != 0)
            {
                return addresses[0];
            }
        }

        return context.Request.ServerVariables["REMOTE_ADDR"];
    }
}