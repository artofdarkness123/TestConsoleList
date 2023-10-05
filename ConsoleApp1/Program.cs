namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var areaInInches = HexagonHelper.GetAreaGivenDiag(12.5M);
            var areaInInches = HexagonHelper.GetAreaGivenDiag(14M);

            var room = new RoomData
            {
                Walls = new List<WallData>
                {
                    new WallData{ WidthInFeet = 10, HeightInFeet = 8 },
                    new WallData{ WidthInFeet = 10, HeightInFeet = 8 },
                    new WallData{ WidthInFeet = 11, HeightInFeet = 8 },
                    new WallData{ WidthInFeet = 11, HeightInFeet = 8 },
                }
            };

            var areaInSQFeet = MathHelper.ConvertSqInchesToSqFeet(areaInInches);
            // var areaInSQFeet = 1.72M; // Elgato Wave Panels
            // var areaInSQFeet = 1M; // 52 Pack Acoustic Panels 1 X 12 X 12 Inches 

            Console.WriteLine("areaInSQFeet = " + areaInSQFeet);

            var wallArea = room.GetWallAreaInSquareFeet();
            Console.WriteLine($"wall area is {wallArea} sq ft");

            var tenPct = wallArea * 0.10M;

            Console.WriteLine($"10% area = {tenPct} sq ft");

            var numOfTileNeeded = tenPct / areaInSQFeet;

            Console.WriteLine($"Number of tiles needed for 10% coverage is {Math.Ceiling(numOfTileNeeded)}");

            Console.ReadLine();
        }
    }
}