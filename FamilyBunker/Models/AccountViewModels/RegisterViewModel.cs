using FamilyBunker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Models.AccountViewModels
{
    public class RegisterViewModel
    {

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string LastNameReg { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string FirstNameReg { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nickname")]
        public string NickNameReg { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Family Code Name")]
        public string FamilyCodeName { get; set; }
        
        [Required]
        public Boolean registerAsParent { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public ICollection<Calendar> Calendars { get; set; }
        public ICollection<groceryList> groceryLists { get; set; }
    }
}
