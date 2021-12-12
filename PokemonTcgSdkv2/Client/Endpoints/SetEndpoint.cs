namespace PokemonTcgSdkV2.Client.Endpoints
{
    public class SetEndpoint : ISupportsIdApiEndpoint<string>
    {
        public string ApiUri => "sets";

        public string IdPath => "id";
    }
}