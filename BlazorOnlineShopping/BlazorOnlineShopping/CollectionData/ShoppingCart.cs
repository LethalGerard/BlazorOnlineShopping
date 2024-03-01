using Blazored.LocalStorage;
namespace BlazorOnlineShopping.CollectionData;

public class ShoppingCart
{
    public List<Product> _cart = new List<Product>();
    public List<Product> Cart => _cart;
    public ILocalStorageService localStorage;

    public ShoppingCart(ILocalStorageService localStorageService) 
    {
        localStorage = localStorageService; 
    }

    public async Task AddToCart(Product product)
    {        
        _cart.Add(product);
        SaveCartAsync();
    }

    public async Task SaveCartAsync()
    {
        await localStorage.SetItemAsync<List<Product>>("shoppingCart", _cart);
    }

    public async Task LoadCartAsync()
    {
        _cart = await localStorage.GetItemAsync<List<Product>>("shoppingCart") ?? new List<Product>();
    }
}