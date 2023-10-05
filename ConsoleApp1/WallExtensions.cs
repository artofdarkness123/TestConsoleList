namespace ConsoleApp1
{
    public static class WallExtensions
    {
        public static decimal GetAreaInSquareFeet(this WallData wall)
        {
            return wall.HeightInFeet * wall.WidthInFeet;
        }
    }
}
