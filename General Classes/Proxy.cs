using Newtonsoft.Json.Linq;

namespace SonarSUPREME.General_Classes
{
    public class Proxy
    {
        public Proxy(string proxyString)
        {
            ProxyString = proxyString;
        }

        public JObject ToJObject()
        {
            JObject obj = new JObject();
            obj["Proxy"] = ProxyString;
            return obj;
        }

        public string ProxyString { get; private set; }
    }
}
