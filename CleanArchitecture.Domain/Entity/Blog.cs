using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace CleanArchitecture.Domain.Entity
{
    public class Blog
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }    
        public string? Description { get; set; } 
        public string? Author { get; set;}

    }
}
