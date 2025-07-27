namespace OwnWallet.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public DateTime? ModificationDate { get; set; } = null;
    }
}
