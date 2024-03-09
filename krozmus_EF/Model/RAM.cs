using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class RAM
    {
        [Key]
        public int RAMID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int ClockSpeed { get; set; }
        public int SingleChipCapacity { get; set; }
        public int ChipAmount { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}
