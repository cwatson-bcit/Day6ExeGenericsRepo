namespace Day6ExeGenericsRepo.Models
{
    /// <summary>
    /// Represents a product entity.
    /// </summary>
    public class Product : Entity
    {
        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal _price { get; set; }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        /// <param name="id">The unique identifier for the product.</param>
        /// <param name="name">The name of the product.</param>
        /// <param name="price">The price of the product.</param>
        public Product(int id, string name, decimal price) : base(id, name)
        {
            _price = price;
        }
    }
}
