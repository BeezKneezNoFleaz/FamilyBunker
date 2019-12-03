using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Entities
{
    public class Member
    {
        public int memberId { get; set; }
        [StringLength(50)]
        public string firstName { get; set; }
        [StringLength(50)]
        public string lastName { get; set; }
        [StringLength(50)]
        public string nickName { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Family Code Name")]
        public string FamilyCodeName { get; set; }


        public ICollection<Calendar> Calendars { get; set; }
        public ICollection<groceryList> groceryLists { get; set; }
    }
}

