﻿using System.ComponentModel.DataAnnotations;


namespace Sanshop.Models
{ 
    public class Sklad
    {
        [Key]
        public Guid Id { get; set; }

        public string NumberSklad { get; set; } = string.Empty;

        public string Adress { get; set; } = string.Empty;

    }
}
