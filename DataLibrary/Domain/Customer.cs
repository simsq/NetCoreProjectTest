using System;

namespace DataLibrary.Domain
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Address = new Address(); 
        } 
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Deleted { get; set; }

        public virtual Address Address { get; set; }

    }
}
