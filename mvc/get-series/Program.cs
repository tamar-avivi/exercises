using GetSeries.Data;
using GetSeries.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
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


// using Microsoft.Data.SqlClient;

// using (SqlConnection conn = new SqlConnection("Server=localhost;Database=GetSeries;User=sa;TrustServerCertificate=true;Password=Aa331573550")) {
//     conn.Open();
//     Console.WriteLine("Connection is just opened");
//     System.Threading.Thread.Sleep(10000);
//     conn.Close();
// }
