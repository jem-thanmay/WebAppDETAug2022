using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

//using WebAPI_2022.Data;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<WebAPI_2022Context>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("WebAPI_2022Context") ?? throw new InvalidOperationException("Connection string 'WebAPI_2022Context' not found.")));
// Add services to the container.

builder.Services.AddControllers().AddOData(options => options.Select().Filter());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
//builder.Services.AddMvc();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
