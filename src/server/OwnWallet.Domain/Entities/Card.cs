namespace OwnWallet.Domain.Entities
{
    public class Card : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double BalanceLimit { get; set; }
    }
}
