using PharmacySystem.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
            "/swagger/v1/swagger.json",
            "PharmacySystemAPI V1"
        );

        options.SwaggerEndpoint(
            "/swagger/V2/swagger.json",
            "PharmacySystemAPI V2"
        );
        options.DefaultModelsExpandDepth(-1);
    });
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseCors(policy =>
    policy.AllowAnyHeader().AllowAnyHeader().AllowAnyMethod());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
