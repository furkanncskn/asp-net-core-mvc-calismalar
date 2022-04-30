using _002_Tuple_ve_Model_Veri_Yollama.Models.ViewModels;
using System.Collections.Generic;

namespace _002_Tuple_ve_Model_Veri_Yollama.Models
{
    public static class DummyData
    {
        public static List<CustomerProduct> customerProducts = new() 
        { 
            new CustomerProduct() 
            { 
                customer = new () 
                { 
                    new() { Name = "Furkan", Surname = "Coşkun", Age = 25 },
                    new() { Name = "Mertali", Surname = "Diyar", Age = 18} 
                },
                product = new () 
                { 
                    new() { Name = "Tarak", Price = 10.99, Stock = 20 }, 
                    new() { Name = "Parfüm", Price = 199.99, Stock = 5}
                }
            }
        };

        public static List<Customer> customers = new()
        {
            new() { Name = "Furkan", Surname = "Coşkun", Age = 25 },
            new() { Name = "Mertali", Surname = "Diyar", Age = 18 }
        };

        public static List<Product> products = new()
        {
            new() { Name = "Tarak", Price = 10.99, Stock = 20 },
            new() { Name = "Parfüm", Price = 199.99, Stock = 5 }
        };
    }
}
