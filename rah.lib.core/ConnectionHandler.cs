﻿using System.IO;
using System.Net;
using System.Text;

namespace rah.lib.core
{
    public class ConnectionHandler
    {
        private const string URI = "https://seugarcom.herokuapp.com/api/";
        public string GetResponse(string postData, string command)
        {            
            var request = (HttpWebRequest)WebRequest.Create($"{URI}{command}/");
            var data = Encoding.UTF8.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
