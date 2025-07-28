namespace OwnWallet.Domain.Entities
{
    public class Invoice
    {
        public string Name { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public Guid CardId { get; set; }
        public Card Card { get; set; }
    }
}
