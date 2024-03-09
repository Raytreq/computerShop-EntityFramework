using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class Computer
    {
        [Key]
        public int ComputerID { get; set; }
        public CPU Processor { get; set; }
        public int CPUID { get; set; }
        public GPU GraphicsCard { get; set; }
        public int GraphicsCardID { get; set; }
        public Disk Disk { get; set; }
        public int DiskID { get; set; }
        public RAM RAMMemory { get; set; }
        public int RAMMemoryID { get; set; }
        public Motherboard Motherboard { get; set; }
        public int MotherboardID { get; set; }
        public PSU PowerSupply { get; set; }
        public int PowerSupplyID { get; set; }
        public string Cooling { get; set; }
        public string ComputerCase { get; set; }
        public string? NetworkCard { get; set;}
    }
}
