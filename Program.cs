using EmergencyDashboard.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MainContext>(db_config => db_config.UseSqlite(builder.Configuration["ConnectionStrings:DB"]));
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddScoped<IAgenciesRepository, AgenciesRepository>();

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
app.MapHub<MainHub>("/emergency");
app.UseAuthorization();

app.MapRazorPages();

app.Run();
