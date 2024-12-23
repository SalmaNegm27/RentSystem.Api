
namespace RentSystem.Infrasturcture.Entities
{
    public class Contract : BaseEntity
    {
        public DateTime RentDurationFrom { get; set; }
        public DateTime RentDurationTo { get; set; }
        public int ContractPeriod { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public int PaymentTermId { get; set; }
        public ContractStatus ContractStatus { get; set; }
        public int ContractStatusId { get; set; }
        public IncreaseType IncreaseType { get; set; }
        public int IncreaseTypeId { get; set; }
        public float AnnualIncreasePercentage { get; set; }
        public decimal? SecurityAmount { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? Penalities { get; set; }
        public decimal? Utilities { get; set; }
        public decimal? Maintenance { get; set; }
        public DateTime DueDateToPay { get; set; }
        public DateTime WhenToIncrease { get; set; }
        public decimal RentAmount { get; set; }
        public string BillerCode { get; set; }
        public string BillerName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int PaymentMethodId { get; set; }
        public Attachment Attachment { get; set; }
        public int AttachmentId { get; set; }


    }
}
