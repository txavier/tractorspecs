﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TractorSpecs.Core.Models
{
    [Table("blogTag")]
    public class blogTag
    {
        public blogTag()
        {
        }

        public int blogTagId { get; set; }
        public string name { get; set; }
    }
}