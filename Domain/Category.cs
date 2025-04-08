namespace TCC2025.TIPS.Models.Domain
{
    public class Category
    {
        public Category(string description) 
        {
            Id = Guid.NewGuid();
            Description = description;
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        public Guid Id { get; private set; }
        public String Description { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public bool IsActive { get; private set; }
    }
}
