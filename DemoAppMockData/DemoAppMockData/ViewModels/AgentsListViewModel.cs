using DemoAppMockData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.ViewModels
{
    public class AgentsListViewModel
    {
        public IEnumerable<Agents> agents { get; set; }

        public string CurrentAgency { get; set; }
    }
}
