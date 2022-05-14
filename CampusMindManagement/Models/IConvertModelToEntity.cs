using CampusMindManagementEntity;

namespace CampusMindManagement.Models
{
    public interface IConvertModelToEntity
    {
        AccessEntity ConvertAccessToEntity(Access access);
        TechnologyEntity ConvertTechnologyToEntity(Technology technology);
        LeadEntity ConvertLeadToEntity(Lead lead);
    }
}