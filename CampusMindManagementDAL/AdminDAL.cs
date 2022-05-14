using CampusMindManagementDAL.Model;
using CampusMindManagementDAL.ModelManager;
using CampusMindManagementEntity;
using CampusMindManagementException;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampusMindManagementDAL
{
    public class AdminDAL : IAdminDAL
    {
        private readonly IConvertEntityModelDAL _convertModelToEntity;
        private readonly CampusMindDbContext _context;
        public AdminDAL(IConvertEntityModelDAL convertModelToEntity)
        {
            _context = new CampusMindDbContext();
            _convertModelToEntity = convertModelToEntity;
        }

        public void AddTechnology(TechnologyEntity technologyEntity)
        {
            Technology technologies = _convertModelToEntity.ConvertTechnologyToModel(technologyEntity);
            try
            {
                

                using(var context = _context)
                {
                    context.Technologies.Add(technologies);
                    context.SaveChanges();
                }
               
            
            }
            catch (SqlException ex)
            {
                throw ex.InnerException;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;

            }


        }

        public void AddAccess(AccessEntity accessEntity)
        {
            Access access = _convertModelToEntity.ConvertAccessToModel(accessEntity);
            try
            {

                using (var context = new CampusMindDbContext())
                {
                    context.Accesses.Add(access);
                    context.SaveChanges();
                }
                
            }
            catch (SqlException ex)
            {
                throw ex.InnerException;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public void AddLead(LeadEntity leadEntity)
        {
             Lead lead = _convertModelToEntity.ConvertLeadToModel(leadEntity);
            try
            {

                using (var context = new CampusMindDbContext())
                {
                    context.Leads.Add(lead);
                    context.SaveChanges();
                }

            }
            catch (SqlException ex)
            {
                throw ex.InnerException;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public void UpdateLead(LeadEntity leadEntity)
        {
            Lead lead = _convertModelToEntity.ConvertLeadToModel(leadEntity);
            try
            {

                using (var context = new CampusMindDbContext())
                {

                    var data = context.Leads.Find(leadEntity.LeadId);
                    if (data != null)
                    {
                        
                        data.LeadName = leadEntity.LeadName;
                        data.TechnologyId = leadEntity.TechnologyId;
                        context.SaveChanges();
                
                    }
                    else
                        throw new DataNotFoundException("Data Not Found");
                }

            }
            catch(DataNotFoundException ex)
            {
                throw ex.InnerException;

            }
            catch (SqlException ex)
            {
                throw ex.InnerException;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
