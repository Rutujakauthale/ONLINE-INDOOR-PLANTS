using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace online_indoor_plant.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Phone Number...")]
        [Display(Name = "Mobileno")]
        public int Mobileno { get; set; }

        [Required(ErrorMessage = "Please Enter Username..")]
        [Display(Name = "UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please Enter the Confirm Password... ")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string Confirmpwd { get; set; }

        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
        public string Email { get; set; }

      

        [Required(ErrorMessage = "Select the Gender...")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

       


    }
}
