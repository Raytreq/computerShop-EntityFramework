using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class GPU
    {
        [Key]
        public int GPUID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string ConnectorType { get; set; }
        public int Memory { get; set; }
        public string MemoryType { get; set; }
        public int MemoryClockSpeed { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}
