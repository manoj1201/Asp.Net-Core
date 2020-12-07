using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAppMockData.Models;
using DemoAppMockData.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoAppMockData.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAgentRepository _agentRepository;

        public HomeController(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                TopRatedAgents = _agentRepository.TopRatedAgent
            };

            return View(homeViewModel);
        }
    }
}