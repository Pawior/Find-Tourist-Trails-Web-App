using Find_Tourist_Trails.Data;
using Find_Tourist_Trails.Repositories;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//                      policy =>
//                      {
//                          policy.WithOrigins("http://localhost:5173/",
//                                              "http://www.contoso.com").AllowAnyHeader()
//                                .AllowAnyMethod(); ;
//                      });
//});

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TrailsDbContext>();
builder.Services.AddScoped<ITrailRepository, SQLTrailRepository>();


var app = builder.Build();




//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

// U¿ywaj nawet jeœli nie jest w lokalny developmencie, chce ¿eby dzia³a³o w chmurze
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

//app.UseCors(MyAllowSpecificOrigins);
app.UseCors("MyPolicy");


app.UseAuthorization();

app.MapControllers();



app.Run();
