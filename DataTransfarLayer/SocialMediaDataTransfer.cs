using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfarLayer
{
    public  class SocialMediaDataTransfer
    {
        public int SocialId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string SocialName { get; set; }

        [Required(ErrorMessage = "Image is Required")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage ="Link is Required")]
        public string Link { get; set; }

       
    }
}
