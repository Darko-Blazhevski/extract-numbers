using System.Text;

namespace extract_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imput;
            do
            {
                imput = Console.ReadLine();
            } while (string.IsNullOrEmpty(imput));

            string inter;
            inter = ekstrakcija(imput);
            Console.WriteLine(inter);

        }

        private static string ekstrakcija(string imput)
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

            return inter;
        }
    }
}