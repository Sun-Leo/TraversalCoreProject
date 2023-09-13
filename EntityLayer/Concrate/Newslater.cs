using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Newslater
    {
        [Key]
        public int NewslaterID { get; set; }
        public string Mail { get; set; }
    }
}
