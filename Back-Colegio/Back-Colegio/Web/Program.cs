using Web.Extendes;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMapperApp();
builder.Services.AddPermissionCorsApp(builder.Configuration);


// Configuracion de la base de datos
builder.Services.AddDb("PgAdmin", builder.Configuration);

// Inyeccion de dependencias de los controladores
builder.Services.AddInject();

//Agrega las validaciones genericas
builder.Services.AddHelpersValidation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())

{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// permite usar los cords
app.UseCors();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
