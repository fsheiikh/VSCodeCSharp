using System;
using System.ComponentModel.DataAnnotations;

namespace DapperApp.Models {
    public class User : BaseEntity {

        [Key]
        public long Id { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        [Compare("password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string confirm_password {get; set;}

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        
    }
}