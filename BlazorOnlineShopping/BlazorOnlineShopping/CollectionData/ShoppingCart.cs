using Blazored.LocalStorage;
using Microsoft.JSInterop;


namespace BlazorOnlineShopping.CollectionData;

public class ShoppingCart
{
    public List<Product> _cart = new List<Product>();
    public List<Product> Cart => _cart;

    public void AddToCart(Product product)
    {
        _cart.Add(product);                
    }

    public async Task SaveCartAsync(ILocalStorageService LocalStorage)
    {
        await LocalStorage.SetItemAsync("shoppingCart", _cart);
    }

    public async Task LoadCartAsync(ILocalStorageService LocalStorage)
    {
        _cart = await LocalStorage.GetItemAsync<List<Product>>("shoppingCart") ?? new List<Product>();
    }
}
