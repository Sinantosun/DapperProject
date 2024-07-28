using DapperProject.Context;
using DapperProject.Services.AboutServices;
using DapperProject.Services.BookingServices;
using DapperProject.Services.CategoryServices;
using DapperProject.Services.ContactServices;
using DapperProject.Services.DashboardServices;
using DapperProject.Services.EventServices;
using DapperProject.Services.FeatureServices;
using DapperProject.Services.MessageServices;
using DapperProject.Services.PhotoServices;
using DapperProject.Services.ProductServices;
using DapperProject.Services.SpecialServices;
using DapperProject.Services.TeamServices;
using DapperProject.Services.TestimonailServices;
using DapperProject.Services.ToDoListServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DapperContext>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IContactService, ContactService>();

builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<ISpecialService, SpecialService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<ITestimonialService, TestimonailService>();
builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IToDoListService, ToDoListService>();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
