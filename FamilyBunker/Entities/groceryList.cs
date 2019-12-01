using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyBunker.Entities
{
    public class groceryList
    {
        [Key]
        public int groceryId { get; set; }
        [StringLength(200)]
        public string itemName { get; set; }
        public int quantity { get; set; }
        [ForeignKey("memberId")]
        public int memberId { get; set; }
    }
}

