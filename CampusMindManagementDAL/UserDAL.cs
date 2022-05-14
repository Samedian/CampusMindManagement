using CampusMindManagementDAL.Model;
using CampusMindManagementDAL.ModelManager;
using CampusMindManagementEntity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CampusMindManagementDAL
{
    public class UserDAL : IUserDAL
    {

        private readonly IConvertEntityModelDAL _convertModelToEntity;
        public UserDAL(IConvertEntityModelDAL convertModelToEntity)
        {
            _convertModelToEntity = convertModelToEntity;
        }

        public List<TechnologyEntity> GetTechnologyDAL()
        {
            using (var context = new CampusMindDbContext())
            {
                var technologies = context.Technologies.ToList();
                List<TechnologyEntity> technologyEntities = _convertModelToEntity.ConvertTechnologyToEntity(technologies);

                return technologyEntities;
            }
            


        }

        public List<LeadEntity> GetLeadDAL()
        {

            using (var context = new CampusMindDbContext())
            {
                List<Lead> leads = context.Leads.ToList();

                List<LeadEntity> leadEntities = _convertModelToEntity.ConvertLeadToEntity(leads);

                return leadEntities;
            }
            

        }

        public List<CandidateEntity> GetCandidateByLead(int leadId)
        {
            using (var context = new CampusMindDbContext())
            {
                List<Candidate> candidates = context.Candidates.ToList().FindAll(x => x.LeadId == leadId);

                List<CandidateEntity> candidateEntities = _convertModelToEntity.ConvertCandidateToEntity(candidates);

                return candidateEntities;
            }
           

        }

        public List<CandidateEntity> GetCandidateByTechnology(int technologyId)
        {

            using (var context = new CampusMindDbContext())
            {

                Lead leads = context.Leads.ToList().FirstOrDefault(x => x.TechnologyId == technologyId);
                List<Candidate> candidates = context.Candidates.ToList().FindAll(x => x.LeadId == leads.LeadId);

                List<CandidateEntity> candidateEntities = _convertModelToEntity.ConvertCandidateToEntity(candidates);

                return candidateEntities;
            }


        }
    }
}
