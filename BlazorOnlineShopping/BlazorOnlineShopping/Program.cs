using BlazorOnlineShopping.CollectionData;
using Blazored.LocalStorage;
using BlazorOnlineShopping.Components;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ProductInventory>();
builder.Services.AddScoped<ShoppingCart>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton<CustomerInfo>();


 //Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
  .AddInteractiveWebAssemblyRenderMode()
.AddInteractiveServerRenderMode()
.AddAdditionalAssemblies(typeof(BlazorOnlineShopping.Client._Imports).Assembly);

//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

app.Run();
