using CampusMindManagementEntity;

namespace CampusMindManagementBAL
{
    public interface IAdminBAL
    {
        void AddTechnology(TechnologyEntity technologyEntity);
        void AddAccess(AccessEntity accessEntity);
        void AddLead(LeadEntity leadEntity);
        void UpdateLead(LeadEntity leadEntity);
        void UpdateTechnology(TechnologyEntity technologyEntity);

    }
}