namespace Application.API
{
    using Carter;
    using Microsoft.AspNetCore.Http;

    public class HomeModule : CarterModule
    {
        public HomeModule()
        {
            Get("/", async (req, res) => All(req, res));
            Get("/pedidos", async (req, res) => All(req, res));
        }

        public void All(HttpRequest req, HttpResponse res)
        {
            res.WriteAsync("Lista de pedidos");
        }
    }
}