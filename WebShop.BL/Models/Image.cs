using System.ComponentModel.DataAnnotations;

namespace WebShop.BL.Models
{
    public class Image
    {
        [Key]
        [MaxLength(256)]
        public string PathID { get; set; }
        public int ProductId { get; set; }
    }
}
