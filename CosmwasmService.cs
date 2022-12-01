using CosmosApi;
using CosmosApi.Extensions;
using CosmosApi.Models;
using CosmosApi.Shared.Models;
using Flurl.Http;

using CosmwasmApi.Models;

namespace CosmwasmServiceApi
{
    public class CosmwasmService : ICosmwasmService
    {
        private readonly Func<IFlurlClient> _clientGetter;
        private readonly ICosmosApiClient _cosmosApiClient;

        
        public CosmwasmService(ICosmosApiClient cosmosApiClient)
        {
            _cosmosApiClient = cosmosApiClient;
        }

        public StdTx ClearAdmin(ClearAdminReq request)
        {
            return ClearAdminAsync(request)
                    .Sync();
        }
        
        
        public async  Task<GasEstimateResponse> ClearAdminSimulationAsync(ClearAdminReq request, CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, true);
            request = new ClearAdminReq(baseReq, request.sender, request.contract);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/contract/{request.contract}/admin",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<GasEstimateResponse>(response.Content);
            
        }
        

        public async Task<StdTx> ClearAdminAsync(ClearAdminReq request, CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, false);
            request = new ClearAdminReq(baseReq, request.sender, request.contract);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/contract/{request.contract}/admin",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<StdTx>(response.Content);
            
        }

        public StdTx ExecuteContract(ExecuteContractReq request)
        {
            return ExecuteContractAsync(request)
                .Sync();
        }
        
        
        
        public async Task<GasEstimateResponse> ExecuteContractSimulationAsync(ExecuteContractReq request, CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, true);
            request = new ExecuteContractReq(baseReq, request.sender, request.contract, request.msg, request.funds);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/code/{request.contract}",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<GasEstimateResponse>(response.Content);
            
        }

        public async Task<StdTx> ExecuteContractAsync(ExecuteContractReq request, CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, false);
            request = new ExecuteContractReq(baseReq, request.sender, request.contract, request.msg, request.funds);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/code/{request.contract}",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<StdTx>(response.Content);
            
        }

        public StdTx InstantiateContract(InstantiateContractReq request)
        {
            return InstantiateContractAsync(request)
                .Sync();
        }
        
        
        public async Task<GasEstimateResponse> InstantiateContractSimulationAsync(InstantiateContractReq request,
            CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, true);
            request = new InstantiateContractReq(baseReq, request.sender, request.admin, request.codeId,
                request.label, request.msg, request.funds);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/code/{request.codeId}",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<GasEstimateResponse>(response.Content);
        }

        public async Task<StdTx> InstantiateContractAsync(InstantiateContractReq request,
            CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, false);
            request = new InstantiateContractReq(baseReq, request.sender, request.admin, request.codeId,
                request.label, request.msg, request.funds);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/code/{request.codeId}",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<StdTx>(response.Content);
        }

        public StdTx MigrateContract(MigrateContractReq request)
        {
            return MigrateContractAsync(request)
                .Sync();
        }
        
        
        
        public async Task<GasEstimateResponse> MigrateContractSimulationAsync(MigrateContractReq request, CancellationToken cancellationToken = default)
        {
            
            var baseReq = new BaseReqWithSimulate(request.BaseReq, true);
            request = new MigrateContractReq(baseReq, request.sender, request.contract, request.codeId, request.msg);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/contract/{request.contract}/code",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<GasEstimateResponse>(response.Content);
            
        }

        public async Task<StdTx> MigrateContractAsync(MigrateContractReq request, CancellationToken cancellationToken = default)
        {
            
            var baseReq = new BaseReqWithSimulate(request.BaseReq, false);
            request = new MigrateContractReq(baseReq, request.sender, request.contract, request.codeId, request.msg);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/contract/{request.contract}/code",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<StdTx>(response.Content);
            
        }

        public StdTx StoreCode(StoreCodeReq request)
        {
            return StoreCodeAsync(request)
                .Sync();
        }

        public async Task<StdTx> StoreCodeAsync(StoreCodeReq request, CancellationToken cancellationToken = default)
        {
            var baseReq = new BaseReqWithSimulate(request.BaseReq, false);
            request = new StoreCodeReq(baseReq, request.sender, request.wasmByteCode, request.instantiatePermission);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync("wasm/code",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<StdTx>(response.Content);

        }
        
        
        public async Task<GasEstimateResponse> StoreCodeSimulationAsync(StoreCodeReq request, CancellationToken cancellationToken = default)
        {
            
            var baseReq = new BaseReqWithSimulate(request.BaseReq, true);
            request = new StoreCodeReq(baseReq, request.sender, request.wasmByteCode, request.instantiatePermission);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync("wasm/code",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<GasEstimateResponse>(response.Content);

        }

        public async Task<StdTx> UpdateAdminAsync(UpdateAdminReq request, CancellationToken cancellationToken = default)
        {

            var baseReq = new BaseReqWithSimulate(request.BaseReq, false);
            request = new UpdateAdminReq(baseReq, request.sender, request.newAdmin, request.contract);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/contract/{request.contract}/admin",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<StdTx>(response.Content);

        }
        
        public async Task<GasEstimateResponse> UpdateAdminSimulationAsync(UpdateAdminReq request, CancellationToken cancellationToken = default)
        {

            var baseReq = new BaseReqWithSimulate(request.BaseReq, true);
            request = new UpdateAdminReq(baseReq, request.sender, request.newAdmin, request.contract);
            var content = _cosmosApiClient.Serializer.SerializeJsonHttpContent(request);
            var response =
                (await _cosmosApiClient.HttpClient.PostAsync($"wasm/contract/{request.contract}/admin",
                    content, cancellationToken))
                .EnsureSuccessStatusCode();
            return await _cosmosApiClient.Serializer.DeserializeJson<GasEstimateResponse>(response.Content);

        }

        public StdTx UpdateAdmin(UpdateAdminReq request)
        {
            return UpdateAdminAsync(request)
                .Sync();
        }
    }
}
