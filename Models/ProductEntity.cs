using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace product_backend.Models
{
    [Table("product_items", Schema = "public")]
    public class ProductEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(true)]

        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string name { get; set; }
        [Column("prices")]
        public int prices { get; set; }
        [Column("status_id")]
        public int status_id { get; set; }
        [Column("quantity")]
        public int quantity { get; set; }
        [Column("category_id")]
        public int category_id { get; set; }
        [Column("image_url")]
        public string image_url { get; set; }
    }
}
