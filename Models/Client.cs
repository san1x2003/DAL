﻿using System.ComponentModel.DataAnnotations;


namespace Sanshop.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        public string Email { get; set; } = string.Empty;

        public int? Phonenumber { get; set; } 

        public string Adress { get; set; } = string.Empty;

    }
}