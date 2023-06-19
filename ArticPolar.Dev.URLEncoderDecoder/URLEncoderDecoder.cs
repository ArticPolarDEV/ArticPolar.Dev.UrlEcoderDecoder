using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticPolar.Dev
{
    public class URLEncoderDecoder
    {
        public static string EncodeText(string text)
        {
            string encodedText = Uri.EscapeDataString(text);
            return encodedText;
        }

        public static string DecodeText(string encodedText)
        {
            string decodedText = Uri.UnescapeDataString(encodedText);
            return decodedText;
        }
    }
}
