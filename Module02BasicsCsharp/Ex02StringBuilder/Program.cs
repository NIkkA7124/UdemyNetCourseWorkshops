using System;
using System.Text;

namespace Ex02StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex2");

            string message1;
            message1 = "add new text";  //now the operation above will work
            Console.WriteLine(message1);

            string message2 = null;
            Console.WriteLine(message2);

            string message3 = string.Empty;
            string text = "He said to me \"The weather is nice today ";
            Console.WriteLine(text);

            string windowslocation = "c:\\windows";
            string fontsfolder = @"c:\windows\fonts";

            string concatenated = string.Concat(text, "isn't it?\"");
            Console.WriteLine(concatenated);
            string concatenated2 = text + "isn't it?\"";
            Console.WriteLine(concatenated2);
            string interpolated = $"{text} isn't it?\"";

            StringBuilder sb = new StringBuilder("This ");
            sb.Append("is ");
            sb.Append("a ");
            sb.Append("very ");
            sb.Append("long ");
            sb.Append("text");  

            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
