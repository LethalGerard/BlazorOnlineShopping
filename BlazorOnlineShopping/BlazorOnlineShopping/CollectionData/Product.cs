using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorOnlineShopping.CollectionData;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Route { get; set; }
    public string ImageUrl { get; set; }


    public Product(int productId, string name, string description, decimal price, int quantity, string route, string imageUrl)
        => (ProductId, Name, Description, Price, Quantity, Route, ImageUrl)
        =  (productId, name, description, price, quantity, route, imageUrl);
}
