using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Color { get; set; }
        [Required]

        public int Speed { get; set; }
        [Required]

        public string Engine { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Available { get; set; }



        public CarType CarType { get; set; }

        [Required]
        public int CartypeId { get; set; }

    }
}
