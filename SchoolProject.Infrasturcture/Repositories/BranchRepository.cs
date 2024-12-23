using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using RentSystem.Domain.Entities;
using RentSystem.Infrasturcture.Abstracts;
using RentSystem.Infrasturcture.InfrastructureBases;
using RentSystem.Infrasturcture.Data;

namespace RentSystem.Infrasturcture.Repositories
{
    public class BranchRepository : GenericRepositoryAsync<Branch>,  IBranchRepository
    {
        #region Fields
        private DbSet<Branch> _branches;
        #endregion

        #region constuctors
        public BranchRepository(ApplicationDBContext dBContext) : base(dBContext)
        {

            _branches = dBContext.Set<Branch>();
        }

        public Task<Branch> GetDepartmentById(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region
        #endregion
    }
}
