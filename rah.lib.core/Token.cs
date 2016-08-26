using Newtonsoft.Json;
using System;
using System.Text;

namespace rah.lib.core
{
    public class Token
    {
        private string _value;
        private string _header;
        private string _payLoad;
        private string _signature;

        public Token()
        {
            _value = string.Empty;
        }

        public string Value
        {
            get { return _value; }
        }

        public string Header
        {
            get { return _header; }
        }

        public string PayLoad
        {
            get { return _payLoad; }
        }

        public string Signature
        {
            get { return _signature; }
        }

        private static byte[] Base64UrlDecode(string input)
        {
            var output = input;
            output = output.Replace('-', '+'); // 62nd char of encoding
            output = output.Replace('_', '/'); // 63rd char of encoding
            switch (output.Length % 4) // Pad with trailing '='s
            {
                case 0: break; // No pad chars in this case
                case 2: output += "=="; break; // Two pad chars
                case 3: output += "="; break; // One pad char
                default: throw new System.Exception("Illegal base64url string!");
            }            
            return Convert.FromBase64String(output); // Standard base64 decoder
        }

        public void load(string value)
        {
            _value = ((dynamic)JsonConvert.DeserializeObject(value)).token;
            string[] content = _value.Split('.');
            _header = content[0];
            _payLoad = Encoding.UTF8.GetString(Base64UrlDecode(content[1]));
            _signature = content[2];
        }
    }
}