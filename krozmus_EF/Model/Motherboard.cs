using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class Motherboard
    {
        [Key] 
        public int MotherboardID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Standard { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}
