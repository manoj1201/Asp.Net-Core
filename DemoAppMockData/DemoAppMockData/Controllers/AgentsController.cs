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
        private readonly IAgents _agents;

        public AgentsController(IAgents agents)
        {
            _agents = agents;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            AgentsListViewModel agentsListViewModel = new AgentsListViewModel();
            agentsListViewModel.agents = _agents.AllAgents;
            agentsListViewModel.CurrentAgency = "SantJust Agents";
            return View(agentsListViewModel);
        }
    }
}