using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotelyApp.Models;

namespace NotelyApp.Services
{
    public class ProductServices
    {
        public Product getProductDetail()
        {
            Product product = new Product("sunglasses", 2);
            return product;
        }
        
    }
}
