
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Entities
{
    public class Box
    {
        [Key]
        public int NameBox { get; set; }
        public string IdBox { get; set; }
    }
}
