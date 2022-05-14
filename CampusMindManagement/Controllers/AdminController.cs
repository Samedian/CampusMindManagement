using CampusMindManagement.Models;
using CampusMindManagementBAL;
using CampusMindManagementEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusMindManagement.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IConvertModelToEntity _convertModelToEntity;
        private readonly IAdminBAL _adminBAL;
        public AdminController(IConvertModelToEntity convertModelToEntity,IAdminBAL adminBAL)
        {
            _convertModelToEntity = convertModelToEntity;
            _adminBAL = adminBAL;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddTechnology()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddTechnology(Technology techonology)
        {
            TechnologyEntity technologyEntity = _convertModelToEntity.ConvertTechnologyToEntity(techonology);
            string message = null;
            try
            {
                _adminBAL.AddTechnology(technologyEntity);
                message = "Success";
            }catch(SqlException )
            {
                message = "Error";
            }catch(Exception)
            {
                message = "Error";
            }
            return Json(new { Message = message, System.Web.Mvc.JsonRequestBehavior.AllowGet });
        }

        [HttpGet]
        public IActionResult AddLead()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddLead(Lead lead)
        {
            LeadEntity leadEntity = _convertModelToEntity.ConvertLeadToEntity(lead);
            string message = null;
            try
            {
                _adminBAL.AddLead(leadEntity);
                message = "Success";
            }
            catch (SqlException)
            {
                message = "Error";
            }
            catch (Exception)
            {
                message = "Error";
            }
            return Json(new { Message = message, System.Web.Mvc.JsonRequestBehavior.AllowGet });
        }


        [HttpGet]
        public IActionResult UpdateLead()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UpdateLead(Lead lead)
        {
            LeadEntity leadEntity = _convertModelToEntity.ConvertLeadToEntity(lead);
            string message = null;
            try
            {
                _adminBAL.UpdateLead(leadEntity);
                message = "Success";
            }
            catch (SqlException)
            {
                message = "Error";
            }
            catch (Exception)
            {
                message = "Error";
            }
            return Json(new { Message = message, System.Web.Mvc.JsonRequestBehavior.AllowGet });
        }
        public IActionResult UpdateTechnology()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UpdateTechnology(Technology technology)
        {
            TechnologyEntity technologyEntity = _convertModelToEntity.ConvertTechnologyToEntity(technology);
            string message = null;
            try
            {
                _adminBAL.UpdateTechnology(technologyEntity);
                message = "Success";
            }
            catch (SqlException)
            {
                message = "Error";
            }
            catch (Exception)
            {
                message = "Error";
            }
            return Json(new { Message = message, System.Web.Mvc.JsonRequestBehavior.AllowGet });
        }
        [HttpGet]
        public IActionResult AddAccess()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAccess(Access access)
        {
            AccessEntity accessEntity = _convertModelToEntity.ConvertAccessToEntity(access);

            string message = null;
            try
            {
                _adminBAL.AddAccess(accessEntity);
                message = "Success";
            }
            catch (SqlException)
            {
                message = "Error";
            }
            catch (Exception)
            {
                message = "Error";
            }
            return Json(new { Message = message, System.Web.Mvc.JsonRequestBehavior.AllowGet });

        }
    }
}
