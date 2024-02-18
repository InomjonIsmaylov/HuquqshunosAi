using ChatGptNet;
using ChatGptNet.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddChatGpt(options =>
{
    // OpenAI.
    options.UseOpenAI(apiKey: "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");

    // Azure OpenAI Service.
    //options.UseAzure(resourceName: "", apiKey: "", authenticationType: AzureAuthenticationType.ApiKey);

    //options.DefaultModel = "gpt-4-1106-preview";
    options.DefaultModel = "chatgpt-4";
    options.DefaultEmbeddingModel = "text-embedding-ada-002";
    options.DefaultParameters = new ChatGptParameters
    {
        MaxTokens = 800,
        Temperature = 0.7
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.Run();
