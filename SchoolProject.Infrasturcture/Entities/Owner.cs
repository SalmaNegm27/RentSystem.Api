using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSystem.Infrasturcture.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public ICollection<Branch> Branches { get; set; }

    }
}
