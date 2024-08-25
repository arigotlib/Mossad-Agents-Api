using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MossadAgentsApi.Models
{
    public class Target
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public string? position { get; set; }
        public string? photo_url { get; set; }
        public int? x {  get; set; }
        public int? y { get; set; }
        public string? direction { get; set; }
    }
}
