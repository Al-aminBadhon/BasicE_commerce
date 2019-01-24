﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicE_commerece.Models
{
    [MetadataType(typeof(MetadataProduct))]
    public partial class Product
    {

    }
    public class MetadataProduct
    {


        [Required]
        [RegularExpression("(a-zA-Z)*")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public double Price { get; set; }
       

    }
}