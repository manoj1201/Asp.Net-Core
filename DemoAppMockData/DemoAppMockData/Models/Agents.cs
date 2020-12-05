using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.Models
{
    public class Agents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ContactNumber { get; set; }
        public int NumberOfDeals { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int Rating { get; set; }
        public int NumberOfReviews { get; set; }
    }
}
