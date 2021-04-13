using System;
using System.Text;

namespace Crypto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Nome item = new Nome("Olá, eu me chamo Eric ° novo especial");
            byte[] bytes;
            Console.WriteLine($"Palavra mencionada: {item}");

            BreakLines(2);
            bytes = Encoding.Default.GetBytes(item.ToString());
            Console.WriteLine($"Get Default bytes: {bytes}");
            PrintBytes(bytes);            
            Console.WriteLine($"Get String: {Encoding.Default.GetString(bytes)}");

            BreakLines(2);
            bytes = Encoding.Unicode.GetBytes(item.ToString());
            Console.WriteLine($"Get Unicode bytes: {bytes}");
            PrintBytes(bytes);            
            Console.WriteLine($"Get String: {Encoding.Unicode.GetString(bytes)}");

            BreakLines(2);
            bytes = Encoding.ASCII.GetBytes(item.ToString());
            Console.WriteLine($"Get ASCII bytes: {bytes}");
            PrintBytes(bytes);            
            Console.WriteLine($"Get String: {Encoding.ASCII.GetString(bytes)}");

            BreakLines(2);
            bytes = Encoding.UTF8.GetBytes(item.ToString());
            Console.WriteLine($"Get UTF8 bytes: {bytes}");
            PrintBytes(bytes);            
            Console.WriteLine($"Get String: {Encoding.UTF8.GetString(bytes)}");
            Console.WriteLine($"Base64: {Convert.ToBase64String(bytes)}");

            BreakLines();

            Console.ReadKey();
        }

        static void BreakLine()
        {
            Console.WriteLine("\n");
        }
        static void BreakLines(int numberLines = 1)
        {
            if (numberLines <= 1) BreakLine();

            for (int i = 1; i < numberLines; i++)
            {
                BreakLine();
            }
            
        }

        static void PrintBytes(byte [] bytes)
        {
            var sb = new StringBuilder("new byte[] { ");
            foreach (var b in bytes)
            {
                sb.Append(b + ", ");
            }
            sb.Append("}");
            Console.WriteLine(sb.ToString());
        }
    }

    public class Nome
    {
        public Nome(string text)
        {
            Text = text;
        }

        private string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }        
    }
}
