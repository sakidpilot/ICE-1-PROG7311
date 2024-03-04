namespace BookstoreApp.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int UserId { get; set; }
        public int InventoryItemId { get; set; }
        public int Quantity { get; set; }

    }
}
