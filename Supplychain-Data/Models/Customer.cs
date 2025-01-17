﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Supplychain_Data.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Eamil { get; set; }

        public ICollection<PickingList> PickingLists { get; set; }
    }
}
