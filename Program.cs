using Catalogo2.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.StaticFiles; // Necesario para el soporte de video

var builder = WebApplication.CreateBuilder(args);

// Configuración de la Base de Datos
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// --- CONFIGURACIÓN DE VIDEOS MP4 ---
var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".mp4"] = "video/mp4";

// Usamos el método tradicional que es más compatible con videos grandes
app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = provider
});

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication(); // Asegúrate de que esté antes de Authorization
app.UseAuthorization();

// Ruta por defecto corregida
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();