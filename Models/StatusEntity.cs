using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace product_backend.Models
{
        [Table("status", Schema = "public")]
        public class StatusEntity
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [ScaffoldColumn(true)]

            [Column("id")]
            public int id { get; set; }

            [Column("name")]
            public bool name { get; set; }
        }
}
