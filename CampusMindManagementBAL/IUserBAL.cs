using CampusMindManagementEntity;
using System.Collections.Generic;

namespace CampusMindManagementBAL
{
    public interface IUserBAL
    {
        List<CandidateEntity> GetCandidateByLead(int leadId);
        List<LeadEntity> GetLeadBAL();
        List<TechnologyEntity> GetTechnologyBAL();
        List<CandidateEntity> GetCandidateByTechnology(int technologyId);
    }
}