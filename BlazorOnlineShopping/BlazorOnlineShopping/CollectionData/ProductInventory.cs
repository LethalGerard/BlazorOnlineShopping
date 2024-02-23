namespace BlazorOnlineShopping.CollectionData;

public class ProductInventory
{
    public static readonly List<Product> _products = new List<Product>();

    public static List<Product> Products => _products;
    
    public ProductInventory()
    {
        SeedData();
    }

    public static void SeedData()
    {
        Product ClownShoes = new(1, "Clown Shoes", "No shoes is a no go, get some!", 249.99m, 10, "clownshoes", "/Images/ClownShoes.jpg");
        Product ClownWig = new(2, "Clown Wig", "Newly plucked hair from consenting Clowns", 399, 5, "clownwig", "/Images/ClownWig.jpg");
        Product ClownMakeUp = new(3, "Clown MakeUp", "Lets look the part with this Vegan Kit", 88, 250, "clownmakeup", "/Images/ClownMakeUp.jpg");
        Product ClownSuit = new(4, "Clown Suit", "Get suited up in this nonItalian quality Clown Suit", 1299, 34, "clownsuit", "/Images/ClownSuit.jpg");
        Product ClownNose = new(5, "Clown Nose", "Dot your i's with this donated clown nose", 24, 55, "clownnose", "/Images/ClownNose.jpg");

        _products.Add(ClownShoes);
        _products.Add(ClownWig);
        _products.Add(ClownMakeUp);
        _products.Add(ClownSuit);
        _products.Add(ClownNose);
    }

    public Product GetProduct(int i) 
    {
        return _products[i-1];
    }
}
