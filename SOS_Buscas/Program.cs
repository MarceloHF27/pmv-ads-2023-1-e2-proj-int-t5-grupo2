using Microsoft.EntityFrameworkCore;
using SOS_Buscas.Data;
using SOS_Buscas.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//------------------------------------------------------------------------------------------------------
//Conexão com o banco
//string mySqlConnection = builder.Configuration.GetConnectionString("DataBase");

builder.Services.AddDbContextPool<BancoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

builder.Services.AddScoped<ICadastro, CadastroRepositorio>();
builder.Services.AddScoped<ILogin, LoginRepositorio>();

//------------------------------------------------------------------------------------------------------

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
