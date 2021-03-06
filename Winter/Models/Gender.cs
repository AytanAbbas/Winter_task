using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Winter.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string GenderName { get; set; }

        public List<Product> Product { get; set; }

    }
}
