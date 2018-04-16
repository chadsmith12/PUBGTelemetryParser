using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web;
using PUBGTelemetryParser.ApiResponses;
using PUBGTelemetryParser.Enums;
using PUBGTelemetryParser.Extensions;

namespace PUBGTelemetryParser.ApiService
{
    public class PubgPlayerService : BaseHttpService
    {
        private readonly IDictionary<string, string> _defaultHeaders;
        private readonly Uri _baseUri = new Uri("https://api.playbattlegrounds.com/shards/");

        public PubgPlayerService()
        {
            _defaultHeaders = new Dictionary<string, string>
            {
                ["Authorization"] = $"Bearer {PubgConfiguration.ApiKey}",
                ["Accept"] = "application/vnd.api+json"
            };
        }

        public async Task<PlayerResponse> GetPlayer(PubgRegion region, string playerId)
        {
            var url = new Uri(_baseUri, $"{region.Serialize()}/players/{playerId}");
            var data = await SendRequestAsync<PlayerResponse>(url, HttpMethod.Get, _defaultHeaders);

            if (!data.Success)
            {
                throw new Exception($"ERROR: Faild to get player - {data.ErrorCode} - {data.ErrorMessage}");
            }

            return data.Data;
        }

        public async Task<FindPlayersResponse> FilterPlayersById(PubgRegion region, params string[] playerIds)
        {
            var playersUrl = new Uri(_baseUri, $"{region.Serialize()}/players");
            var url = new UriBuilder(playersUrl);
            var query = HttpUtility.ParseQueryString(url.Query);
            query["filter[playerIds]"] = string.Join(',', playerIds);
            url.Query = query.ToString();

            var data = await SendRequestAsync<FindPlayersResponse>(url.Uri, HttpMethod.Get, _defaultHeaders);
            if (!data.Success)
            {
                throw new Exception($"ERROR: Faild to find players - {data.ErrorCode} - {data.ErrorMessage}");
            }

            return data.Data;

        }
    }
}
