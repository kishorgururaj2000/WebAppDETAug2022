using Microsoft.EntityFrameworkCore;
using ToDoApiDemo1.Models;
using Microsoft.Extensions.DependencyInjection;
using ToDoApiDemo1.Data;
using Microsoft.AspNetCore.OData;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoApiDemo1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoApiDemo1Context") ?? throw new InvalidOperationException("Connection string 'ToDoApiDemo1Context' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddOData(options =>
                options.Select()); ;
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();