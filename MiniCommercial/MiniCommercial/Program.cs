using Microsoft.EntityFrameworkCore;
using MiniCommercial.Data;
using MiniCommercial.Services;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURATION DE LA BASE DE DONNÉES ---
// Lit la chaîne de connexion "DefaultConnection" dans appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// --- 2. ENREGISTREMENT DES SERVICES (LOGIQUE MÉTIER) ---
// Indispensable pour que les contrôleurs puissent utiliser les services
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IOrderService, OrderService>();

// --- 3. CONFIGURATION DE CORS POUR ANGULAR ---
// Permet au Front-end (souvent sur le port 4200) d'appeler l'API
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.AllowAnyOrigin() // En production, spécifiez l'URL exacte
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

// --- 4. CONFIGURATION SWAGGER (DOCUMENTATION) ---
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// --- 5. CONFIGURATION DU PIPELINE HTTP ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Activer CORS avant l'autorisation
app.UseCors("AllowAngular");

app.UseAuthorization();

app.MapControllers();

app.Run();