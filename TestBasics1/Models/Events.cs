namespace TestBasics1.Models
{
    public class Events
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public DateTime Date { get; set; }

        public Events()
        {
            Date = DateTime.Now;

        }
    }
}
