using Microsoft.EntityFrameworkCore;
using RentSystem.Data.Entities;
using RentSystem.Domain.Entities;
using RentSystem.Infrasturcture.Abstracts;
using RentSystem.Infrasturcture.Data;
using RentSystem.Infrasturcture.InfrastructureBases;

namespace RentSystem.Infrasturcture.Repositories
{
    public class OwnerRepository : GenericRepositoryAsync<Owner>, IOwnerRepository
    {
        #region Fields
        #endregion

        #region constuctors
        public OwnerRepository(ApplicationDBContext dBContext) : base(dBContext)
        {

        }

        #endregion
        #region
        #endregion
    }

}
