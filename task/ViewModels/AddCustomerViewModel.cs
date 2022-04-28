using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace task.ViewModels
{
    public class AddCustomerViewModel
    {
        [Required(ErrorMessage ="This Field IS Required")]
        [MaxLength(10,ErrorMessage ="max length is 10")]
        [MinLength(3,ErrorMessage ="min length is 3")]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set;}
    }
}