using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using razor_demo.Data;
using razor_demo.DataInitial;
using razor_demo.NewFolder;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'AppDbContext' not found.")));

// Đăng ký Repository
builder.Services.AddScoped<CatagoryData, CatagoryData>();
builder.Services.AddScoped<ValidateData, ValidateData>();

var app = builder.Build();

// Gọi hàm SeedData để khởi tạo dữ liệu mẫu
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.Initialize(services); // Gọi SeedData để khởi tạo dữ liệu
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Đã xảy ra lỗi khi khởi tạo dữ liệu mẫu.");
    }
}

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

app.MapRazorPages();

app.Run();
