namespace RoomWeave.Server.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HouseId { get; set; }
        public int FloorId { get; set; }

        public string Description { get; set; }
        public decimal Size { get; set; }
        public bool IsTrapped { get; set; }
    }
}
