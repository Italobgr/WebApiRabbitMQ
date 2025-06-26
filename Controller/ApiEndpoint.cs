using WebApiRabbitMQ.Relatorios;

namespace WebApiRabbitMQ.Controller
{



    public static class ApiEndpoint
    {
        public static void AddApiEndpoints(this WebApplication app)
        {
            app.MapPost("solicitar-relatorio/{name}", (string name) =>
            {
                var solicitacao = new SolicitacaoRelatorio
                {
                    Id = Guid.NewGuid(),
                    Nome = name,
                    Status = "Pendente",
                    ProcessedTime = null
                };

                Lista.Relatorios.Add(solicitacao);
                return Results.Ok(solicitacao);
            });

            app.MapGet("relatorios", () => Results.Ok(Lista.Relatorios));

        }

    }

    public record HelloResponse(string Message);

}


