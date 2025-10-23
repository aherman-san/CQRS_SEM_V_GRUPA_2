namespace ExampleCQRS.DTOS
{
    public class SimpleProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string DisplayPrice { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Image => $"https://placehold.co/600x400/34d399/ffffff?text={Category}";
    }
}
