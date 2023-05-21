using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfarLayer
{
   public class UserDataTranfer
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Password is required")]
        public string  Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string ImagePath { get; set; }

        public bool IsAdmin { get; set; }


    }
}
