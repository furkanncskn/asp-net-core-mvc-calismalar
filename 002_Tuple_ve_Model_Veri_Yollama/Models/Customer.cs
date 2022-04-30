using System.ComponentModel.DataAnnotations;

namespace _002_Tuple_ve_Model_Veri_Yollama.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }    
    }
}
