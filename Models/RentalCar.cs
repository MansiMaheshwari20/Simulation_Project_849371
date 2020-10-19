using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class RentalCar
    {
        [Key]
        public int Idclient { get; set; }

        [Required]

        public string Nameclient { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string Adhar { get; set; }

        public Car Car { get; set; }
        [Required]

        public int CarId { get; set; }
    }
}
