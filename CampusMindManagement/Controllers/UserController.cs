using CampusMindManagementBAL;
using CampusMindManagementEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusMindManagement.Controllers
{
    [Authorize(Roles ="User")]
    public class UserController : Controller
    {
        private readonly IUserBAL _userBAL;
        public UserController(IUserBAL userBAL)
        {
            _userBAL = userBAL;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CampusMindByLead()
        {
            List<LeadEntity> leadEntities = _userBAL.GetLeadBAL();
            ViewBag.Data = leadEntities;
            return View();
        }

        [HttpPost]
        public IActionResult CampusMindByLead(int LeadId)
        {
            List<CandidateEntity> candidateEntities = _userBAL.GetCandidateByLead(LeadId);
            ShowCandidate(candidateEntities);
            return View("ShowCandidate");

        }

        [HttpGet]
        public IActionResult CampusMindByTechnology()
        {
            List<TechnologyEntity> technologyEntities = _userBAL.GetTechnologyBAL();
            ViewBag.Data = technologyEntities;
            return View();
        }

        [HttpPost]
        public IActionResult CampusMindByTechnology(int TechonolgyId)
        {
            List<CandidateEntity> candidateEntities = _userBAL.GetCandidateByTechnology(TechonolgyId);
            ShowCandidate(candidateEntities);
            return View("ShowCandidate");

        }

        public IActionResult ShowCandidate(List<CandidateEntity> candidateEntities)
        {
            ViewBag.Data = candidateEntities;
            return View();
        }

    }
}
