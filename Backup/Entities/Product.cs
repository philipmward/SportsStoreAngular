namespace SportsStore.Data.Entities
{
    public class Product
    {
        #region Public Properties

        public string Category { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        #endregion Public Properties
    }
}