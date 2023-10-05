namespace ConsoleApp1
{
    public class RoomData
    {
        public ICollection<WallData> Walls { get; set; } = new List<WallData>();
    }
}
