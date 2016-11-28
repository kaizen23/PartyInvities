using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvities.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać maila")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać prawidłowy email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Proszę podać czy weźmiesz udział")]
        public bool? WillAttend  { get; set; }

    }
}