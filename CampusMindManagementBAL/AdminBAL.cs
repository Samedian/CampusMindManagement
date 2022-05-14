using CampusMindManagementDAL;
using CampusMindManagementEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMindManagementBAL
{
    public class AdminBAL : IAdminBAL
    {
        private readonly IAdminDAL _adminDAL;
        public AdminBAL(IAdminDAL adminDAL)
        {
            _adminDAL = adminDAL;
        }
        public void AddAccess(AccessEntity accessEntity)
        {
            _adminDAL.AddAccess(accessEntity);
        }

        public void AddLead(LeadEntity leadEntity)
        {
            _adminDAL.AddLead(leadEntity);
        }

        public void AddTechnology(TechnologyEntity technologyEntity)
        {
            _adminDAL.AddTechnology(technologyEntity);
        }

        public void UpdateLead(LeadEntity leadEntity)
        {
            _adminDAL.UpdateLead(leadEntity);

        }

        public void UpdateTechnology(TechnologyEntity technologyEntity)
        {
            throw new NotImplementedException();
        }
    }
}
