using CampusMindManagementEntity;
using System.Collections.Generic;

namespace CampusMindManagementDAL
{
    public interface IUserDAL
    {
        List<CandidateEntity> GetCandidateByLead(int leadId);
        List<TechnologyEntity> GetTechnologyDAL();
        List<LeadEntity> GetLeadDAL();
        List<CandidateEntity> GetCandidateByTechnology(int technologyId);
    }
}