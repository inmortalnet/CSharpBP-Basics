using Acme.Common;
using System;
using static Acme.Common.LoggingService;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        #region Constructors
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
        #endregion

        #region Properties
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
        #endregion

        #region Methods

        public string Print()
        {
            var vendor = new Vendor();
            vendor.SendWelcomeEmail("Message from Product instance");

            var emailService = new EmailService();
            emailService.SendMessage("New Product", this.name, "sales@abc.com");

            var result = LogAction("Print method in Product class");

            return string.Format("[{0}] {1}: {2}", Id, Name, Description);
        }

        #endregion        
    }
}
