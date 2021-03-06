using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagementSystem.Models
{
    public class Customer
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public int Phone { get; set; }
        public string Address  { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
