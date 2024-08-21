using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MossadAgentsApi.Models
{
    internal class Agent
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Nickname { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public string Status { get; set; }
    }
}
