namespace OwnWallet.Domain.Entities
{
    public class CardExpenses : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime BuyDate { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid UserCardId { get; set; }
        public UserCard UserCard { get; set; }
    }
}
