using DemoAppMockData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Agents> TopRatedAgents { get; set; }
    }
}
