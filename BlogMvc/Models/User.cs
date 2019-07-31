using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int UserPassword { get; set; }
        [Required]
        public string UserMail { get; set; }
        

    } 
}
