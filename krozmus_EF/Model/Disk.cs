using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF.Model
{
    public class Disk
    {
        [Key]
        public int DiskID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Capacity { get; set; }
        public string Format { get; set; }
        public string Interface { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}
