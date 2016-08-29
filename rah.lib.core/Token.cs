using Newtonsoft.Json;
using System;
using System.Text;

namespace rah.lib.core
{
    public class Token
    {
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

        public string Value { get; set; }
        public string Header { get; set; }
        public string PayLoad { get; set; }
        public string Signature { get; set; }

        public void load(string value)
        {
            Value = ((dynamic)JsonConvert.DeserializeObject(value)).token;
            string[] content = Value.Split('.');
            Header = content[0];
            PayLoad = Encoding.UTF8.GetString(Base64UrlDecode(content[1]));
            Signature = content[2];
        }
    }
}