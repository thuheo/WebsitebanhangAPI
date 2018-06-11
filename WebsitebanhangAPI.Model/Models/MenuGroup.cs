﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsitebanhangAPI.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tự động tăng
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { get; set; }

    }
}
