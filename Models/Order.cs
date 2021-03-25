using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksManagementSystem.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }


        public int BooksID { get; set; }
        public Books Books { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
