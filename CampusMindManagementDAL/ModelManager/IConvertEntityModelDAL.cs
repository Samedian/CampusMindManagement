using CampusMindManagementDAL.Model;
using CampusMindManagementEntity;
using System.Collections.Generic;

namespace CampusMindManagementDAL.ModelManager
{
    public interface IConvertEntityModelDAL
    {
        List<CandidateEntity> ConvertCandidateToEntity(List<Candidate> candidates);
        List<LeadEntity> ConvertLeadToEntity(List<Lead> leads);
        List<TechnologyEntity> ConvertTechnologyToEntity(List<Technology> technologies);
        Technology ConvertTechnologyToModel(TechnologyEntity technologyEntity);
        Access ConvertAccessToModel(AccessEntity accessEntity);
        Lead ConvertLeadToModel(LeadEntity leadEntity);
    }
}