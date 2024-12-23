using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentSystem.Domain.Entities;
using RentSystem.Infrasturcture.Abstracts;
using RentSystem.Infrasturcture.Data;
using RentSystem.Infrasturcture.InfrastructureBases;

namespace RentSystem.Infrasturcture.Repositories
{
    public class ContractRepository : GenericRepositoryAsync<Contract>, IContractRepository
    {
        public ContractRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
        }
    }
}
