using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCustomDb.Data
{
    class House
    {
        public City City { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        public int Height { get; set; }
    }
}
