using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.Models
{
    public interface IAgents
    {
        IEnumerable<Agents> AllAgents { get; }

        Agents GetAgentById(int agentId);
    }
}
