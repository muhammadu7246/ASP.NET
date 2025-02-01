
namespace Project.Controllers
{
    internal class Product
    {
        public int Id { get; internal set; }
        public decimal Price { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public DateTime CreatedDate { get; internal set; }
    }
}