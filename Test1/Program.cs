internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", async (context) =>
        {
            string nome = context.Request.Query["nome"];
            await context.Response.WriteAsync(text: $"Hello {nome}!");

        });

        app.Run();
    }
}