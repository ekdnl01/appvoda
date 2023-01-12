using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace app_voda.Tables
{
    public class UserRegistration
    {
        [Required, MaxLength(20), EmailAddress]
        public Guid UserId { get; set; }
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
    }
}
