using Csr.Areas.Identity;
using Csr.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;


var builder = WebApplication.CreateBuilder(args);
//DataProtection
//Csr.Common.Utils.SetDataProtection(builder.Services, @"D:\DataProtection\", "Csr", Csr.Common.CryptoType.CngCbc);
//builder.Services.AddDataProtection()
//    .PersistKeysToFileSystem(new DirectoryInfo(@"D:\DataProtection\"))
//    .SetDefaultKeyLifetime(TimeSpan.FromDays(14))
//    .SetApplicationName("Csr");

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<CsrContext>(options =>
//    options.UseSqlServer(connectionString));builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(connectionString));

//Sqlite
//Sqlite
//builder.Services.AddDbContext<CsrDbContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
//MSSQL
builder.Services.AddDbContext<CsrDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
//builder.Services.AddSingleton<WeatherForecastService>();

//MudBlazor 추가
builder.Services.AddMudServices();

//쿠키인증으로 추가 20211202
builder.Services.AddAuthentication(defaultScheme: Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.AccessDeniedPath = "/Account/CsrLogin/Login"; //이걸로 사용되지 않음 App.razor 파일에 NotAuthorized <Csr.Pages.LoginRedirect></Csr.Pages.LoginRedirect>
        options.LoginPath = "/Account/CsrLogin/Login";
    }); 
//Author
builder.Services.AddAuthorization();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

//쿠키정책 - todo  SameSite 설정
app.UseCookiePolicy();  //SameSite...

app.UseAuthentication(); 
//Authorize
app.UseAuthorization(); 


app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
