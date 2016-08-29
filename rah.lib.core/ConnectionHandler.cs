using System.IO;
using System.Net;
using System.Text;

namespace rah.lib.core
{
    public class ConnectionHandler
    {
        private const string URI = "https://seugarcom.herokuapp.com/api/";

        public string GetResponse(string postData, string command, string header)
        {            
            var request = (HttpWebRequest)WebRequest.Create($"{URI}{command}/");
            var data = Encoding.UTF8.GetBytes(postData);
            request.Method = "POST";            
            if (header != "")
            {
                request.Method = "GET";
                request.Headers.Add("x-access-token", header);                
            }
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public string GetResponse(string postData, string command)
        {
            return GetResponse(postData, command, "");
        }
    }
}
