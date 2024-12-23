
namespace RentSystem.Infrasturcture.Entities
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public string BranchId { get; set; }
        public string City { get; set; }
        public Decimal RentAmount { get; set; }
        public string Address { get; set; }
        public string MapLink { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string PosTerminalId { get; set; }
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }

    }
}
