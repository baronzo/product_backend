using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace product_backend.Data
{
    public class Status
    {
        [Key]
        public int id { get; set; }
        public bool name { get; set; }
    }
}
