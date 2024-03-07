namespace idClaimPractise.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductsId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = string.Empty;
        public string Brands { get; set; }= string.Empty;

    }
}
