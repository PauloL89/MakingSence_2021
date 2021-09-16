
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Entities
{
    public class Brand
    {
        [Key]
        public int IdBrand { get; set; }
        public string NameBrand { get; set; }
    }
}
