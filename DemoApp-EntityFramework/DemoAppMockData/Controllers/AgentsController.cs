using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAppMockData.Models;
using DemoAppMockData.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoAppMockData.Controllers
{
    public class AgentsController : Controller
    {
        private readonly IAgentRepository _agentRepository;

        public AgentsController(IAgentRepository agentrepository)
        {
            _agentRepository = agentrepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            AgentsListViewModel agentsListViewModel = new AgentsListViewModel();
            agentsListViewModel.agents = _agentRepository.AllAgent;
            agentsListViewModel.CurrentAgency = "SantJust Agents";
            return View(agentsListViewModel);
        }

        public IActionResult AgentDetails(int id)
        {
            var agent = _agentRepository.GetAgentById(id);
            if (agent == null)
                return NotFound();

            return View(agent);
        }
    }
}