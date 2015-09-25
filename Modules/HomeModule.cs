
namespace FriendLetterApp
{
using Nancy;
using nancytest.Objects;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters => View["hello.cshtml"];
            Get["/favorite_photos"] = parameters => View["favorite_photos.html"];
            Get["/form"] = parameters => View["form.html"];
            Get["/greeting_card"] = parameters => {
              var letterNames = new LetterNames {
                Sender = this.Request.Query["Sender"],
                Recipient = this.Request.Query["Recipient"]
              };
              return View["greeting-card.html", letterNames];
            };
        }
    }
}
