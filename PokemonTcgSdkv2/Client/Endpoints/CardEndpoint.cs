namespace PokemonTcgSdkV2.Client.Endpoints
{
    public class CardEndpoint : ISupportsIdApiEndpoint<string>
    {
        public string ApiUri => "cards";

        public string IdPath => "id";
    }
}