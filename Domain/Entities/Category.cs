using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category:Entity
    {
        public string Name { get; set; }
        public List<Product> Products{ get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
