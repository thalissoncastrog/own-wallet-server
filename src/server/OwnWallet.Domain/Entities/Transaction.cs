namespace OwnWallet.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int TypeId { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
