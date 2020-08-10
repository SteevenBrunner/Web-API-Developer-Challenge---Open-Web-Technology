namespace Web_API_Developer_Challenge___Open_Web_Technology.Models
{
    public class Skills
    {
        public enum Levels
        {
            Beginner,
            Intermediate,
            Advanced,
            Expert
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Levels Level { get; set; }

    }
}