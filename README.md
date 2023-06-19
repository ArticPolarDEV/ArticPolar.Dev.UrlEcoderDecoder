# ArticPolar.Dev.UrlEcoderDecoder
Encoder and Decoder Text to Browser Readable Format

## Example of Use
````
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticPolar.Dev;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainText = "Hello !$World&*<>";
            string encodedText = URLEncoderDecoder.EncodeText(mainText);
            Console.WriteLine("Encoded Text: " + encodedText);
            string decodedText = URLEncoderDecoder.DecodeText(encodedText);
            Console.WriteLine("Decoded Text: " + decodedText);
            Console.ReadLine();
        }
    }
}

````
