using restfulproject.Models.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient(typeof(restfulproject         .Models.EF.ShoppingDbNikhilContext));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(cors =>
{
    cors.AddDefaultPolicy(defaultpolicy =>
    {
        defaultpolicy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
    //cors.AddPolicy("vendorA", vendorpolicy =>
    //{
    //    vendorpolicy.WithOrigins(new string[] { "https://www.transportmanagement.com","https://www.cognizantHR"})
    //})
});
var app = builder.Build();
//comment added
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
