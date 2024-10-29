using Urban.Storm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlite("Data Source=../Registrar.sqlite", 
    b => b.MigrationsAssembly("Urban.Storm.Api"))); 
    
    
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(); 

  