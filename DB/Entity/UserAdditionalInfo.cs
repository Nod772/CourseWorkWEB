﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entity
{
    [Table("tblUserAdditionalInfo")]
    public class UserAdditionalInfo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Image { get; set; }
        public virtual User User { get; set; }
    }
}
