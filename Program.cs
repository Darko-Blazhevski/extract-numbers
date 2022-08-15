using System.Text;

namespace extract_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? imput;
            do
            {
                imput = Console.ReadLine();
            } while (string.IsNullOrEmpty(imput));

            int inter;
            inter = ekstrakcija(imput);
            Console.WriteLine(inter);

        }

        private static int ekstrakcija(string imput)
        {
            string inter = string.Empty;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(imput);
            foreach (var item in asciiBytes)
            {
                if (item <= 57 && item >= 47)
                {
                    inter = inter + Convert.ToChar(item);
                }
                else
                {
                    continue;
                }
            }
            int a =int.Parse(inter);
            return a;
        }
    }
}