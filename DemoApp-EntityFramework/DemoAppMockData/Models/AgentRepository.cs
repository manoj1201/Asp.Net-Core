using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.Models
{
    public class AgentRepository : IAgentRepository
    {
        private readonly AppDbContext _appDbContext;

        public AgentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Agents> AllAgent
        {

            get
            {
                return _appDbContext.Agents;
            }
        }

        public IEnumerable<Agents> TopRatedAgent
        {
            get
            {
                return _appDbContext.Agents;
            }
        }

        public Agents GetAgentById(int agentId)
        {
            return _appDbContext.Agents.FirstOrDefault(agnt => agnt.Id == agentId);
        }
    }
}
