using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfictionaryApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        [StringLength(60, ErrorMessage = "Product name cant be Longer than 60 characters")]
        public string Title { get; set; }
        [Display(Name = "Product Summery")]
        public string Summery { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
