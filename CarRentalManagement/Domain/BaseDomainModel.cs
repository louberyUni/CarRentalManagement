namespace CarRentalManagement.Domain
{
    public abstract class BaseDomainModel
    {
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
