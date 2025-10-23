namespace ExampleCQRS.DTOS
{
    public class SimpleProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string DisplayPrice { get; set; } = string.Empty;
    }
}
