using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string FamilyCodeName { get; set; }
    }
}
