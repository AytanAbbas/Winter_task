using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string tName { get; set; }

        public List<Product> Product { get; set; }

    }
}
