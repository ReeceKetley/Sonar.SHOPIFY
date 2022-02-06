using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using SonarRESTOCK;
using SonarSUPREME.General_Classes;

static class CurrentApiUser
{
    public static ApiUser User;
}

public class ApiResponseObject
{
    public string Status;
    public string Message;
    public ApiUser User;
    public ApiResponseObject(string status, string message, ApiUser user = null)
    {
        Status = status;
        Message = message;
        User = user;
    }
}

public class ApiUser
{
    public string Username;
    public string Password;
    public int MaxAccounts;

    public ApiUser(string username, string password, string maxacounts)
    {
        Username = username;
        Password = password;
        MaxAccounts = Convert.ToInt32(maxacounts);
    }
}
class ApiLogin
{
    HTTP _http = new HTTP("");
    public string Username;
    public string Password;
    public string MaxAccounts;
    private string Flag;
    public ApiLogin(string username, string password, string flag)
    {
        Username = username.Trim();
        Password = password.Trim();
        Flag = flag.Trim();
    }

    public ApiResponseObject Login()
    {
        var login = new JObject();
        login["username"] = Username;
        login["password"] = Password;
        login["device"] = GetUDID();
        login["flag"] = Flag;
        var post = Crypto.EncryptRJ256(Functions.RandomString(15) + login.ToString());
        _http.IncludeHeaderInResponse = false;
        try
        {
            var response = _http.Post("http://api.nikesonar.com/api.php", "v=" + HttpUtility.UrlEncode(post) + "&sonar=true");
            if (string.IsNullOrEmpty(response))
            {
                return new ApiResponseObject("HttpError", "There was an issue connecting to the api.");
            }
            response = Crypto.DecryptRJ256(response);
            response = response.Substring(response.IndexOf("{"));
            var responseObject = JObject.Parse(response);
            if (responseObject["status"].ToString() == "success")
            {
                var user = new ApiUser(Username, Password, responseObject["limit"].ToString());
                BotConfiguration.CurrentApiUser = user;
                return new ApiResponseObject("Success", "Login succesfull", user);
            }
            if (responseObject["status"].ToString() == "linked")
            {
                var user = new ApiUser(Username, Password, responseObject["limit"].ToString());
                BotConfiguration.CurrentApiUser = user;
                return new ApiResponseObject("Success", "Device Linked", user);
            }
            if (responseObject["status"].ToString() == "max")
            {
                return new ApiResponseObject("Fail", "Maximum Devices");
            }
            if (responseObject["status"].ToString() == "invalid")
            {
                return new ApiResponseObject("Fail", "Invalid Credentials");
            }
        }
        catch
        {
            return new ApiResponseObject("Invalid Credentials", "Invalid Credentials");
        }
        return new ApiResponseObject("Unkown", "You do not have permision to use this product");
    }

    public enum Key { Windows };
    public static byte[] GetRegistryDigitalProductId(Key key)
    {
        byte[] digitalProductId = null;
        RegistryKey registry = null;
        switch (key)
        {
            case Key.Windows:
                registry =
                  Registry.LocalMachine.
                    OpenSubKey(
                      @"SOFTWARE\Microsoft\Windows NT\CurrentVersion",
                        false);
                break;
        }
        if (registry != null)
        {
            digitalProductId = registry.GetValue("DigitalProductId")
              as byte[];
            registry.Close();
        }
        return digitalProductId;
    }

    public static string GetUDID()
    {
        byte[] results = GetRegistryDigitalProductId(Key.Windows);
        return Crypto.EncryptRJ256(results + Environment.UserName);
    }
}

