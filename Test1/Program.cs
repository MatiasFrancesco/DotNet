internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.UseDeveloperExceptionPage();
        app.UseStaticFiles();

        app.MapGet("/", async (context) =>
        {
            string nome = "";
            nome = context.Request.Query["nome"];
            await context.Response.WriteAsync(text: $"Hello {nome}!");

        });

        app.Run();
    }
}