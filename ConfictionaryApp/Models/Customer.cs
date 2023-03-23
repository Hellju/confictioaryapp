using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConfictionaryApp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "the LastName Length cannot be longer than 30 character")]
        [Display(Name = "LastName")]
        public string LName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "the LastName Length cannot be longer than 60 character")]
        [Display(Name = "FirstName")]
        public string FName { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public string FullName 
        {
            get { return LName + " " + FName; }
        }

    }
}
