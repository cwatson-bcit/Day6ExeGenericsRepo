namespace Day6ExeGenericsRepo.Models
{
    /// <summary>
    /// Represents the base entity class.
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public int _id { get; set; }

        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string _name { get; set; }

        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        /// <param name="id">The unique identifier for the entity.</param>
        /// <param name="name">The name of the entity.</param>
        public Entity(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
