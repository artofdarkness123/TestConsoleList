namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var area = HexagonHelper.GetAreaGivenDiag(12.5M);

            Console.WriteLine(area);

            Console.ReadLine();
        }
    }
}