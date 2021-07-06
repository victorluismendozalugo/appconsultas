using Nancy;

namespace apiServices.Modules
{
    public class RootModule : NancyModule
    {
        public RootModule()
        {
            Get("/", _ => GetRoot());
        }

        private object GetRoot()
        {
            return Response.AsJson("Los servicios API Rest se encuentran funcionando ... :)");
        }
    }
}