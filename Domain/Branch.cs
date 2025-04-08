namespace TCC2025.TIPS.Models.Domain
{
    public class Branch
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

    }
}
