namespace CaddyShackMVC.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GolfBag GolfBag { get; set; }
        public int GolfBagId { get; set; }
    }
}