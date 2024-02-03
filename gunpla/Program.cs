var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();  // Aktivers MVC

var app = builder.Build();

app.UseStaticFiles();  // Använda statiska filer som css eller js
app.UseRouting();  // Använda routing

// Skapa egna routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
