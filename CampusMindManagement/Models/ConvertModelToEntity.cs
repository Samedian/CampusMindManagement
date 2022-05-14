using CampusMindManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusMindManagement.Models
{
    public class ConvertModelToEntity : IConvertModelToEntity
    {

        public TechnologyEntity ConvertTechnologyToEntity(Technology technology)
        {
            TechnologyEntity technologyEntity = new TechnologyEntity();
            technologyEntity.TechonolgyId = technology.TechonolgyId;
            technologyEntity.TechnologyName = technology.TechnologyName;

            return technologyEntity;
        }
        public AccessEntity ConvertAccessToEntity(Access access)
        {
            AccessEntity accessEntity = new AccessEntity();
            accessEntity.UserName = access.UserName;
            accessEntity.Password = access.Password;
            accessEntity.RoleAssign = access.RoleAssign;

            return accessEntity;
        }

        public LeadEntity ConvertLeadToEntity(Lead lead)
        {
            LeadEntity leadEntity = new LeadEntity();
            leadEntity.LeadId = lead.LeadId;
            leadEntity.LeadName = lead.LeadName;
            leadEntity.TechnologyId = lead.technologyId;

            return leadEntity;
        }
    }

    
}
