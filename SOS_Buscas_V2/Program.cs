using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SOS_Buscas_V2.Data;
using SOS_Buscas_V2.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//----------------------------------------------------------------------------------------------------------------
//Conexão com o banco

string conection = builder.Configuration.GetConnectionString("SOS_BuscasDB");

builder.Services.AddDbContextPool<BancoContext>(options => options.UseSqlServer(conection));

builder.Services.AddScoped<IUsuario, UsuarioRepositorio>();

//----------------------------------------------------------------------------------------------------------------


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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
