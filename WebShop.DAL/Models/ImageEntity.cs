using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL.Models
{
    public class ImageEntity
    {
        [Key]
        [MaxLength(256)]
        public string PathID { get; set; }
        public int ProductId { get; set; }
    }
}
