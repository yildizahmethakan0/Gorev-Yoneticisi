namespace GorevYonetici.Models
{
    public class Gorev 
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
    }
}
