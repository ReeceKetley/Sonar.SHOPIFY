using System.Collections.Generic;
using System.Threading;
using SonarRESTOCK;

public static class BotConfiguration
{
    public static string MainProxy = "";
    public static List<Thread> ActiveThreads = new List<Thread>();
    public static int RefreshInterval = 30*1000;
    public static string NikeCheck;
    public static string email;
    public static ApiResponseObject ResponseObject;
    public static string type;
    public static int max;
    public static ApiUser CurrentApiUser;
    public static bool SonarLinked;
}

