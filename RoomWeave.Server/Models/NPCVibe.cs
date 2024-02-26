namespace RoomWeave.Server.Models
{
    public class NPCVibe
    {
        public int Id { get; set; }
        public int NPCId { get; set; }
        public int UserId { get; set; }
        public double VibeScore { get; set; }
        public string ? Note { get; set; }


    }
}
