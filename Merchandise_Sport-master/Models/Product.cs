using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Merchandise_Sport_master.Models
{
    public class Product
    {
        [Key]
        public int SerialNumber { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]

        public int Size { get; set; }
        [Required]
        [Range(0, 600)]
        [DataType(DataType.Currency)]

        public int Price { get; set; }
        [Required]

        public string Image { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
