namespace BlazorCrash.Web.Models
{
    public class Product
    {
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                // If using an event callback or property changed notification, trigger it here
            }
        }
        public string Name { get; set; }
        public bool isActive { get; set; }

        public IEnumerable<ProductProps> ProductProps { get; set; }
    }
}
