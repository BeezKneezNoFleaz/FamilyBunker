using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Entities
{
    public class Calendar
    {
        public int calendarId { get; set; }
        [StringLength(100)]
        public string eventName { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }


        [StringLength(100)]
        [Display(Name = "Family Code Name")]
        public string FamilyCodeName { get; set; }


        public int memberId { get; set; }
    }
}
