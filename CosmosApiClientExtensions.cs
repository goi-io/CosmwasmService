using System;
using CosmosApi;
using CosmosApi.Endpoints;
using CosmwasmServiceApi;

namespace CosmwasmApi
{
    public static class CosmosApiClientExtensions
    {
        public static ICosmwasmService CreateCosmwasmService(this ICosmosApiClient cosmosApiClient)
        {
            return new CosmwasmService(cosmosApiClient);
        }
    }
}