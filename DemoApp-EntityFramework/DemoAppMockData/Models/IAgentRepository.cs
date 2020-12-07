using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.Models
{
    public interface IAgentRepository
    {
        IEnumerable<Agents> AllAgent { get; }

        Agents GetAgentById(int agentId);

        IEnumerable<Agents> TopRatedAgent { get; }
    }
}
