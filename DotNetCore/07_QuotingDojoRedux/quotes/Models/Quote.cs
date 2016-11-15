using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DapperApp.Models {
    public class Quote : BaseEntity {

        [Key]
        public int Id { get; set; }

        [Required]
        public string quote { get; set; }

        public User user { get; set; }

        public int user_id { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated { get; set; }
            
    }
}