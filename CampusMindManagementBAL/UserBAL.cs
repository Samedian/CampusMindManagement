using CampusMindManagementDAL;
using CampusMindManagementEntity;
using System;
using System.Collections.Generic;

namespace CampusMindManagementBAL
{
    public class UserBAL : IUserBAL
    {
        private readonly IUserDAL _userDAL;
        public UserBAL(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public List<LeadEntity> GetLeadBAL()
        {
            List<LeadEntity> leadEntities = _userDAL.GetLeadDAL();
            return leadEntities;
        }

        public List<CandidateEntity> GetCandidateByLead(int leadId)
        {
            List<CandidateEntity> candidateEntities = _userDAL.GetCandidateByLead(leadId);
            return candidateEntities;
        }

        public List<TechnologyEntity> GetTechnologyBAL()
        {
            List<TechnologyEntity> technologyEntities = _userDAL.GetTechnologyDAL();
            return technologyEntities;
        }

        public List<CandidateEntity> GetCandidateByTechnology(int technologyId)
        {
            List<CandidateEntity> candidateEntities = _userDAL.GetCandidateByTechnology(technologyId);
            return candidateEntities;
        }

    }
}
