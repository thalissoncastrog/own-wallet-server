namespace OwnWallet.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
