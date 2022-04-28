using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace task.ViewModels
{
    public class AddSampleVM
    {
        [Required(ErrorMessage = "this field is required")]
        [MinLength(3,ErrorMessage ="Min Leanth is 3")]
        [MaxLength(20,ErrorMessage ="max Leanth is 20")]
        public string name { set; get; }
        [Display(Name = " Reciving side")]
        [Required(ErrorMessage ="this field is required")]
        public int receivingSideId { get; set; }
        [Display(Name = " Client")]
        [Required(ErrorMessage = "this field is required")]
        public int clientId { get; set; }
        [Display(Name = " Reciving Date")]
        [Required(ErrorMessage ="This  field is Required")]
        public DateTime recevingDate { get; set; }

        [Required(ErrorMessage =" THIS FIELD IS REQUIRED ")]
        [Display(Name = " Describtion")]
        [MinLength(10,ErrorMessage ="Describtion must be between 20-40")]
        [MaxLength(30,ErrorMessage ="Describtion must be between 20-40")]
        public string describtion { get; set; }
       [Range(1,20,ErrorMessage = "range between 1-20")]
        public int numberOfSamples { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [Display(Name = " Attachments")]

        public string attachments { get; set; }
        [Required(ErrorMessage = "this field is required")]
        [Display(Name = "Clients  Attachments")]

        public string clienAttachments { set; get; }
        [Required(ErrorMessage = "this field is required")]
        [Display(Name = "state")]
       [Range(1.00,20.00,ErrorMessage ="range between 1-20")]

        public double sampleCost { set; get; }
        [Display(Name = "Sample  Costs")]

        public bool status { set; get; }
    }
}