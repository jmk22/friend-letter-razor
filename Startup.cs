namespace FriendLetterApp
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
    using Nancy;
    using Nancy.ViewEngines.Razor;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return "/Users/jillkuchman/Documents/csharp-samples/friend-letter-razor";
        }
    }
}
