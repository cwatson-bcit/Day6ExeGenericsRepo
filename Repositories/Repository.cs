using Day6ExeGenericsRepo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day6ExeGenericsRepo.Repositories
{
    /// <summary>
    /// Repository class for managing a collection of entities.
    /// Must inherit from Entity.
    /// </summary>
    /// <typeparam name="T">The type of the entity</typeparam>
    public class Repository<T> where T : Entity
    {
        private List<T> _items = new List<T>();

        /// <summary>
        /// Adds an item to the repository.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(T item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Updates an item in the repository.
        /// </summary>
        /// <param name="id">The ID of the item to update.</param>
        /// <param name="item">The new value of the item.</param>
        public void Update(int id, T item)
        {
            int index = GetItemIndex(id);

            if (index > 0)
            {
                _items[index] = item;
            }
        }

        /// <summary>
        /// Deletes an item from the repository.
        /// </summary>
        /// <param name="id">The ID of the item to delete.</param>
        public void Delete(int id)
        {
            int index = GetItemIndex(id);

            if (index > 0)
            {
                _items.RemoveAt(index);
            }
        }
        /// <summary>
        /// Retrieves all items from the repository.
        /// </summary>
        /// <returns>A list of all items.</returns>
        public List<T> GetAll()
        {
            return _items;
        }

        /// <summary>
        /// Retrieves an item by its ID.
        /// </summary>
        /// <param name="id">The ID of the item to retrieve.</param>
        /// <returns>The item with the specified ID, or null if not found.</returns>
        public T Get(int id)
        {
            T item = _items.FirstOrDefault(i => i._id == id);

            return item;
        }

        /// <summary>
        /// Finds the index of an item in the repository.
        /// </summary>
        /// <param name="id">The ID of the item.</param>
        /// <returns>The index of the item, or -1 if not found.</returns>
        private int GetItemIndex(int id)
        {
            int index = _items.FindIndex(i => i._id == id);

            return index;
        }
    }
}
