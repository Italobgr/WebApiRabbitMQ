   namespace WebApiRabbitMQ.Controller
    {



        public static class ApiEndpoint
        {
            public static void AddApiEndpoints(this WebApplication app)
            {
                app.MapGet("Hello-World", () => Results.Ok(new HelloResponse("Hello")));
            }
        }

        public record HelloResponse(string Message);




    }


/*
WebApiRabbitMQnamespace WebAPIRabbitMQ.Controller
{
  
    

        public static class ApiEndpoint
        {
            public static void AddApiEndpoints(this WebApplication app)
            {
                app.MapGet("Hello-World", () => Results.Ok(new HelloResponse("Hello")));
            }
        }

        public record HelloResponse(string Message);



    
}

 */

