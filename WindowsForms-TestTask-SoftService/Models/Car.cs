using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_TestTask_SoftService.Models
{
    [Table("cars")]
    public class Car
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public double Mileage { get; set; }
        [Required]
        public double Speed { get; set; }
    }
}
