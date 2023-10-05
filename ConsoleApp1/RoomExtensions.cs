namespace ConsoleApp1
{
    public static class RoomExtensions
    {
        public static decimal GetWallAreaInSquareFeet(this RoomData room)
        {
            return room?.Walls?.Sum(x => x.GetAreaInSquareFeet()) ?? 0;
        }
    }
}
