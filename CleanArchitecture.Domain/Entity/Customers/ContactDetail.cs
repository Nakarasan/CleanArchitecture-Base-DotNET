using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Customers
{
    public class ContactDetail
    {
        public int Id { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
        public Customer customers { get; set; }
    }
}
