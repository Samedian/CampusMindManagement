using CampusMindManagementEntity;

namespace CampusMindManagementDAL
{
    public interface IAdminDAL
    {
        void AddTechnology(TechnologyEntity technologyEntity);
        void AddAccess(AccessEntity accessEntity);
        void AddLead(LeadEntity leadEntity);
        void UpdateLead(LeadEntity leadEntity);
    }
}