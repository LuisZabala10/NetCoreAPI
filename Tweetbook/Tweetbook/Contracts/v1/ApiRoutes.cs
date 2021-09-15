namespace Tweetbook.Contracts
{
    public static class ApiRoutes
    {
        const string Root = "api";
        const string Version = "v1";
        public const string BaseRoute = Root+"/"+Version;
        public static class Post{
            public const string GetAll = BaseRoute+"/posts";
            // public static readonly string Get = $"{BaseRoute}/posts/";
            // public static readonly string Create = $"{BaseRoute}/posts";
            // public static readonly string Delete = $"{BaseRoute}/posts";
        }
    }
}