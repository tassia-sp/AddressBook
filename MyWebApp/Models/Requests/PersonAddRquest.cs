﻿using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class PersonAddRquest
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool Favorite { get; set; }
    }
    
}