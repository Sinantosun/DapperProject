using DapperProject.BigData.DapperEfServices.Dapper;
using DapperProject.BigData.DapperEfServices.EF;
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
using DapperProject.Services.WhyUsServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DapperContext>();
builder.Services.AddScoped<BigDataDapperContext>();
builder.Services.AddDbContext<BigDataEFContext>();


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
builder.Services.AddScoped<IBigDataDapperService, BigDataDapperService>();
builder.Services.AddScoped<IBigDataEFService, BigDataEFService>();
builder.Services.AddScoped<IWhyUsService, WhyUsService>();

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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
