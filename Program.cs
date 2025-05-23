using NotificationDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Đăng ký các notification service
builder.Services.AddSingleton<EmailNotificationService>();
builder.Services.AddSingleton<SMSNotificationService>();
builder.Services.AddSingleton<PushNotificationService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Notification}/{action=Index}/{id?}");

app.Run();
