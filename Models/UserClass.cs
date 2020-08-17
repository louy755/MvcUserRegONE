using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcUserRegONE.Models
{
    public class UserClass
    {
        
        [Required(ErrorMessage = "Enter Username !")]
        [Display(Name = "Enter Username :")]
        [StringLength(maximumLength: 7, MinimumLength = 3, ErrorMessage = "Username Length Must be Max 7 & Min 3")]
        public string Uname { get; set; }

        [Required(ErrorMessage = "Please Enter your Email Address")]
        [Display(Name = "Email Id")]
        public string Uemail { get; set; }

        [Required(ErrorMessage ="Enter your Password!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Upwd { get; set; }

        [Required(ErrorMessage = "Enter your Password!")]
        [Display(Name = "Re-Password")]
        [DataType(DataType.Password)]
        [Compare("Upwd")]
        public string Repwd { get; set; }

        [Required(ErrorMessage ="Select Gender Please!")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Upload your Image Please")]
        [Display(Name = " Profile Image")]
        public string Uimg { get; set; }


    }
}