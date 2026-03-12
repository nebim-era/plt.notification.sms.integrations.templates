using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/send-sms", async (JsonObject request, [FromServices] IHttpClientFactory httpClientFactory) =>
{
    // send-sms codes here
    Results.Ok();
});

app.MapPost("/validate-settings", async (JsonObject settings, [FromServices] IHttpClientFactory httpClientFactory) =>
{
    //validate-settings code here
    Results.Ok();
});

app.Run();