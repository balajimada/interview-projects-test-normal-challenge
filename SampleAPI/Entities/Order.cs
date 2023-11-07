using System.ComponentModel.DataAnnotations;

namespace SampleAPI.Entities
{
    public class Order
    {
        [Required]
        [Key]
        public int OrderID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        public string Descritption { get; set; }
        public bool Denoting { get; set; } = true;
    }
}
