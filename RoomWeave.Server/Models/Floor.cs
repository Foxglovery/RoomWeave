namespace RoomWeave.Server.Models
{
    public class Floor
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        public string Name { get; set; }
        public bool IsBasement { get; set; }
        public int IsAttic { get; set; }
    }
}
