namespace TreeViewSample
{
    public class ProductViewModel
    {
        public readonly Product Product;
        public string Name => Product.Name;

        public ProductViewModel(Product product)
        {
            Product = product;
        }
    }
}
