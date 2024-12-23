namespace RentSystem.Infrasturcture.Entities
{
    public class Request : BaseEntity
    {
        public int Comment { get; set; }
        public ICollection<Attachment>? Attachments { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
        public Contract Contract { get; set; }
        public int ContractId { get; set; }
        public int RequestStatusId { get; set; }
        public RequestStatus RequestStatus { get; set; }

    }
}
