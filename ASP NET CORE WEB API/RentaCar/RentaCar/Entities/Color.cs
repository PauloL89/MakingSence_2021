
using System.ComponentModel.DataAnnotations;

namespace RentaCar.Entities
{
    public class Color
    {
        [Key]
        public int IdColor { get; set; }
        public string NameColor { get; set; }
    }
}
