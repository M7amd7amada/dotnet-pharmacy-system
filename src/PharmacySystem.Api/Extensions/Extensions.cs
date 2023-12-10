using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;

namespace PharmacySystem.Api.Extensions;

public static class Extensions
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddHttpsRedirection(options => options.HttpsPort = 44350);
        builder.Services.AddControllers();
        builder.Services.AddCors();

        builder.AddSwagger();
        builder.AddVersioning();
    }

    public static void AddSwagger(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc(
                "v1",
                new OpenApiInfo { Version = "v1.0", Title = "PharmacySystemAPI" }
            );
            options.SwaggerDoc(
                "v2",
                new OpenApiInfo { Version = "v2.0", Title = "PharmacySystemAPI" }
            );
        });
    }

    public static void AddVersioning(this WebApplicationBuilder builder)
    {
        builder.Services.AddApiVersioning(options =>
        {
            // * Configure The Api Versioning To Use URI Versioning * //
            options.ApiVersionReader = new UrlSegmentApiVersionReader();
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1, 0);
        });

        builder.Services.AddVersionedApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });
    }
}