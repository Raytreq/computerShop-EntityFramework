using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class PSU
    {
        [Key]
        public int PSUID { get; set; }
        public int Wattage { get; set; }
        public string Standard { get; set; }
        public string EnergyEfficiency { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}
