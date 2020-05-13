using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Name:")]
        [StringLength(5)]
        [Required(ErrorMessage = "Length of name no more than 5 symbols")]
        public string Name { get; set; }

        [Display(Name = "Surname:")]
        [StringLength(5)]
        [Required(ErrorMessage = "Length of name no less than 5 symbols")]
        public string surName { get; set; }

        [Display(Name = "Adress:")]
        [StringLength(19)]
        [Required(ErrorMessage = "Length of name no more than 15 symbols")]
        public string adres { get; set; }

        [Display(Name = "Phone number:")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Length of name no more than 10 symbols")]
        public string phone { get; set; }

        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Length of name no more than 25 symbols")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetails> orderDetails { get; set; }
    }
}
