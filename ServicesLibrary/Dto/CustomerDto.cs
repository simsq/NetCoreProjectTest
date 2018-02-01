using DataLibrary.Domain;

namespace ServicesLibrary.Dto
{
    public class CustomerDto
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Deleted { get; set; }

    }
}
