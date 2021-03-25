using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagementSystem.Models
{
    public class Books
    {
        public int ID { get; set; }
        
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
