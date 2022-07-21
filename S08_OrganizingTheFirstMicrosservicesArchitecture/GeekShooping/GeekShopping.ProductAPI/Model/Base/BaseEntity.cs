﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base {
    public class BaseEntity {
        // Key é uma annotations
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}
