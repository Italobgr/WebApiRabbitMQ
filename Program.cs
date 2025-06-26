using System.Text.Json.Serialization;
using WebApiRabbitMQ.Controller;
using WebApiRabbitMQ.Relatorios;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

app.AddApiEndpoints();

app.Run();

//teste para depuração ---
//public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);






[JsonSerializable(typeof(SolicitacaoRelatorio))]

[JsonSerializable(typeof(List<SolicitacaoRelatorio>))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
