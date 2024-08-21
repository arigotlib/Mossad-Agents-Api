using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MossadAgentsApi.Models
{
    internal class Target
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
