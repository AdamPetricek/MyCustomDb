using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCustomDb.Data
{
    class City
    {
        public ICollection<House> Houses { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
