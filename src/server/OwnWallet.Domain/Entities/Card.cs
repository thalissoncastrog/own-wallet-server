namespace OwnWallet.Domain.Entities
{
    public class Card : BaseEntity
    {
        public string Name { get; set; }
        public int ClosingDay { get; set; }
        public int DueDay { get; set; }
        public double Limit { get; set; }
    }
}
