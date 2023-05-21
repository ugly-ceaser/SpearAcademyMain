using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfarLayer
{
    public class MetaDataTransfer
    {
        public int MetaId { get; set; }

        public string MetaName { get; set; }

        [Required(ErrorMessage ="Content Feild is Required")]
        public string MetaContent { get; set; }
    }
}
