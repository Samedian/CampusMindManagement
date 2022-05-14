using CampusMindManagementDAL.Model;
using CampusMindManagementEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMindManagementDAL.ModelManager
{
    public class ConvertEntityModelDAL : IConvertEntityModelDAL
    {
        public Access ConvertAccessToModel(AccessEntity accessEntity)
        {
            Access access = new Access();
            access.UserName = accessEntity.UserName;
            access.Password = accessEntity.Password;
            access.RoleAssign = accessEntity.RoleAssign;

            return access;
        }

        public List<CandidateEntity> ConvertCandidateToEntity(List<Candidate> candidates)
        {

            List<CandidateEntity> candidateEntities = new List<CandidateEntity>();

            foreach (var item in candidates)
            {
                CandidateEntity candidateEntity = new CandidateEntity();
                candidateEntity.CandidateId = item.CandidateId;
                candidateEntity.CandidateName = item.CandidateName;
                candidateEntity.LeadId = item.LeadId;

                candidateEntities.Add(candidateEntity);
            }

            return candidateEntities;
        }

        public List<LeadEntity> ConvertLeadToEntity(List<Lead> leads)
        {
            List<LeadEntity> leadEntities = new List<LeadEntity>();

            foreach (var item in leads)
            {
                LeadEntity leadEntity = new LeadEntity();
                leadEntity.LeadId = item.LeadId;
                leadEntity.LeadName = item.LeadName;
                leadEntity.TechnologyId = item.TechnologyId;

                leadEntities.Add(leadEntity);
            }

            return leadEntities;
        }

        public Lead ConvertLeadToModel(LeadEntity leadEntity)
        {
            Lead lead = new Lead();
            lead.TechnologyId = leadEntity.TechnologyId;
            lead.LeadName = leadEntity.LeadName;
            lead.LeadId = leadEntity.LeadId;

            return lead;
        }

        public List<TechnologyEntity> ConvertTechnologyToEntity(List<Technology> technologies)
        {
            List<TechnologyEntity> technologyEntities = new List<TechnologyEntity>();

            foreach (var item in technologies)
            {
                TechnologyEntity technologyEntity = new TechnologyEntity();
                technologyEntity.TechonolgyId = item.TechonolgyId;
                technologyEntity.TechnologyName = item.TechnologyName;

                technologyEntities.Add(technologyEntity);
            }

            return technologyEntities;
        }

        public Technology ConvertTechnologyToModel(TechnologyEntity technologyEntity)
        {
            Technology technology = new Technology();
            technology.TechonolgyId = technologyEntity.TechonolgyId;
            technology.TechnologyName = technologyEntity.TechnologyName;

            return technology;
        }
    }
}
