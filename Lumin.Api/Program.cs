using Lumin.Api.Mapping;
using Lumin.Core;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddMappings();
    builder.Services.AddCore();

    builder.Services.AddCors();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.UseCors(builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });

    app.MapControllers();

    app.Run();

}