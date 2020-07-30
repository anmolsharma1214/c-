using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleasedYear { get; set; }
        public int Length { get; set; }
        public int Rating { get; set; }

        
    }
}
