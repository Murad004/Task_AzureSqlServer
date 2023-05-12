using Microsoft.EntityFrameworkCore;
using Task_AzureSqlServer.Models;
using Task_AzureSqlServer.Service.Abstract;
using Task_AzureSqlServer.Service.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IRepository, Repository>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Muradsadikhov39Context>(option =>
{
    option.UseSqlServer("Data Source=sadikhovmurad.database.windows.net;Initial Catalog=muradsadikhov39;User ID=adminmurad;Password=@murad123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
});

//string connectionString = builder.Configuration.GetConnectionString("Azure_SQL_Connection");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
