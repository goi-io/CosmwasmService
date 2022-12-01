

using CosmosApi.Models;
using CosmosApi.Shared.Models;
using System.Threading;
using System.Threading.Tasks;
using CosmwasmApi.Models;

namespace CosmwasmServiceApi
{
    /// Msg defines the wasm Msg service interface.
    public partial interface ICosmwasmService
    {
        /// StoreCode to submit Wasm code to the system async
        Task<StdTx> StoreCodeAsync(StoreCodeReq request, 
            CancellationToken cancellationToken = default);
        /// StoreCode to submit Wasm code to the system
        StdTx StoreCode(StoreCodeReq request);
        
        
        /// <summary>
        /// StoreCode to submit Wasm code to the system async
        /// [GAS ESTIMATE]
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GasEstimateResponse> StoreCodeSimulationAsync(StoreCodeReq request, 
            CancellationToken cancellationToken = default);






        /// Instantiate creates a new smart contract instance for the given code id (async)
        Task<StdTx> InstantiateContractAsync(InstantiateContractReq request, 
            CancellationToken cancellationToken = default);
        /// Instantiate creates a new smart contract instance for the given code id 
        StdTx InstantiateContract(InstantiateContractReq request);
        
        /// <summary>
        /// Instantiate creates a new smart contract instance for the given code id (async)
        /// [GAS ESTIMATE]
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GasEstimateResponse> InstantiateContractSimulationAsync(InstantiateContractReq request, 
            CancellationToken cancellationToken = default);
        
        



        
        
        /// Execute submits the given message data to a smart contract (async)
        Task<StdTx> ExecuteContractAsync(ExecuteContractReq request,
            CancellationToken cancellationToken = default);
        /// Execute submits the given message data to a smart contract 
        StdTx ExecuteContract(ExecuteContractReq request);
        

        /// <summary>
        /// Execute submits the given message data to a smart contract (async)
        /// [GAS ESTIMATE]
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GasEstimateResponse> ExecuteContractSimulationAsync(ExecuteContractReq request,
            CancellationToken cancellationToken = default);





        /// Migrate runs a code upgrade/ downgrade for a smart contract (async)
        Task<StdTx> MigrateContractAsync(MigrateContractReq request,
            CancellationToken cancellationToken = default);
        /// Migrate runs a code upgrade/ downgrade for a smart contract
        StdTx MigrateContract(MigrateContractReq request);
        
        
        

        /// <summary>
        ///  Migrate runs a code upgrade/ downgrade for a smart contract (async).
        ///  [GAS ESTIMATE]
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GasEstimateResponse> MigrateContractSimulationAsync(MigrateContractReq request,
            CancellationToken cancellationToken = default);


        

        /// UpdateAdmin sets a new   admin for a smart contract (async)
        Task<StdTx> UpdateAdminAsync(UpdateAdminReq request,
            CancellationToken cancellationToken = default);
        /// UpdateAdmin sets a new   admin for a smart contract (async)
        StdTx UpdateAdmin(UpdateAdminReq request);
        
        /// <summary>
        /// UpdateAdmin sets a new   admin for a smart contract (async)
        /// [GAS ESTIMATE]
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GasEstimateResponse> UpdateAdminSimulationAsync(UpdateAdminReq request,
            CancellationToken cancellationToken = default);

        
        

        /// ClearAdmin removes any admin stored for a smart contract (async)
        Task<StdTx> ClearAdminAsync(ClearAdminReq request,
            CancellationToken cancellationToken = default);

        /// ClearAdmin removes any admin stored for a smart contract (async)
        StdTx ClearAdmin(ClearAdminReq request);
        
        /// <summary>
        /// ClearAdmin removes any admin stored for a smart contract (async)
        /// [GAS ESTIMATE]
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<GasEstimateResponse> ClearAdminSimulationAsync(ClearAdminReq request,
            CancellationToken cancellationToken = default);



    }
}
