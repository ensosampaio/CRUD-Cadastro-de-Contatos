using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using ControleDeContatos.Data;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Http;
using ControleDeContatos.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container

// Add database context
builder.Services.AddDbContext<BancoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

// Add scoped repository
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<ISessao, Sessao>();

builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
});



// Add MVC controllers with views
builder.Services.AddControllersWithViews();

// Add Authorization (if required)
builder.Services.AddAuthorization();

// Add Authentication (example: JWT or Cookie authentication)
builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Use Authentication and Authorization middleware
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

// Configure route mapping
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();