// Create a WebApplicationBuilder instance with command-line arguments.
using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Register services for the CategoryRepository and PieRepository.
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

// Register the services needed for controllers and views.
builder.Services.AddControllersWithViews();

// Build the WebbApplication.
var app = builder.Build();

// Enable serving of static files (e.g., CSS, JavaScript, images) in the application.
app.UseStaticFiles();

// Check if the application is running in the development environment.
if (app.Environment.IsDevelopment())
{
    // If in development mode, use a developer-friendly exception page for error handling.
    app.UseDeveloperExceptionPage();
}

// Define a route for handling HTTP GET requests at the root URL ("/").
app.MapGet("/", () => "Hello World!");

// Start the application and listen for incoming HTTP requests.
app.Run();
