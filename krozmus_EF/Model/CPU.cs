using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class CPU
    {
        [Key]
        public int CPUID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Series { get; set; }
        public string Socket { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public int Memory { get; set; }
        public double ClockSpeed { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}
