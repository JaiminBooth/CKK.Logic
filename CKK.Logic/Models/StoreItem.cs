namespace CKK.Logic.Models
{
    public class StoreItem
    {
        public Product product;
        public int quantity;

        public StoreItem(Product StProduct, int StQuantity)
        {
            product = StProduct;
            quantity = StQuantity;
        }
        public Product GetProduct()
        {
            return product;
        }
        public void SetProduct(Product StProduct)
        {
            product = StProduct;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int StQuantity)
        {
            quantity = StQuantity;
        }
    }
}