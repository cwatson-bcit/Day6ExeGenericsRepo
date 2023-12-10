namespace Day6ExeGenericsRepo.Models
{
    /// <summary>
    /// Represents a customer entity.
    /// </summary>
    public class Customer : Entity
    {
        /// <summary>
        /// Gets or sets the email address of the customer.
        /// </summary>
        public string _email { get; set; }

        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        /// <param name="id">The unique identifier for the customer.</param>
        /// <param name="name">The name of the customer.</param>
        /// <param name="email">The email address of the customer.</param>
        public Customer(int id, string name, string email) : base(id, name)
        {
            _email = email;
        }
    }
}
