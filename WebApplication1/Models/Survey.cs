namespace WebApplication1.Models
{
    public class Survey
    {
        public string? fullName { get; set; }
        public string? email { get; set; }
        public DateTime madeDate { get; set; }
        public string? contact { get; set; }

        public Boolean choice { get; set; }
        public Boolean check { get; set; }
    }
}
