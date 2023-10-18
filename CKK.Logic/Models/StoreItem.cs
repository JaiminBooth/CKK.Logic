namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product product;
        private int quantity;

        public StoreItem(Product SIProduct, int SIQuantity)
        {
            product = SIProduct;
            quantity = SIQuantity;
        }
        public Product GetProduct()
        {
            return product;
        }
        public void SetProduct(Product SIProduct)
        {
            product = SIProduct;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int SIQuantity)
        {
            quantity = SIQuantity;
        }
    }
}