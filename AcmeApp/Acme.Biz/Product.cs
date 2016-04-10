using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Product instance created.");
        }

        public Product(int id, string name, string description) : this()
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;

            Console.WriteLine("Product instance has name: {0}", Name);
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Print()
        {
            return String.Format("[{0}] {1}: {2}", Id, Name, Description);
        }

    }
}
