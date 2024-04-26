using Microsoft.AspNetCore.Identity;

namespace LegalCaseManagement.Models
{
    public class Client : IdentityUser
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public List<Case> Cases { get; set; } = new List<Case>();
    }
}
