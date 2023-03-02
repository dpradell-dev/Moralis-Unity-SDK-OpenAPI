/*
 * EVM API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Moralis.EvmApi.Client;
using Moralis.EvmApi.Model;

namespace Moralis.EvmApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetMutipleNFTsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Multiple NFTs
        /// </summary>
        /// <remarks>
        /// Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </remarks>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <returns>List&lt;NftOwner&gt;</returns>
        List<NftOwner> GetMultipleNFTs(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?));

        /// <summary>
        /// Get Multiple NFTs
        /// </summary>
        /// <remarks>
        /// Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </remarks>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <returns>ApiResponse of List&lt;NftOwner&gt;</returns>
        ApiResponse<List<NftOwner>> GetMultipleNFTsWithHttpInfo(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetMutipleNFTsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Multiple NFTs
        /// </summary>
        /// <remarks>
        /// Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </remarks>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;NftOwner&gt;</returns>
        System.Threading.Tasks.Task<List<NftOwner>> GetMultipleNFTsAsync(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Multiple NFTs
        /// </summary>
        /// <remarks>
        /// Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </remarks>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;NftOwner&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<NftOwner>>> GetMultipleNFTsWithHttpInfoAsync(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetMutipleNFTsApi : IGetMutipleNFTsApiSync, IGetMutipleNFTsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GetMutipleNFTsApi : IDisposable, IGetMutipleNFTsApi
    {
        private Moralis.EvmApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public GetMutipleNFTsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public GetMutipleNFTsApi(string basePath)
        {
            this.Configuration = Moralis.EvmApi.Client.Configuration.MergeConfigurations(
                Moralis.EvmApi.Client.GlobalConfiguration.Instance,
                new Moralis.EvmApi.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Moralis.EvmApi.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Moralis.EvmApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public GetMutipleNFTsApi(Moralis.EvmApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Moralis.EvmApi.Client.Configuration.MergeConfigurations(
                Moralis.EvmApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Moralis.EvmApi.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Moralis.EvmApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GetMutipleNFTsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GetMutipleNFTsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Moralis.EvmApi.Client.Configuration.MergeConfigurations(
                Moralis.EvmApi.Client.GlobalConfiguration.Instance,
                new Moralis.EvmApi.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Moralis.EvmApi.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Moralis.EvmApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GetMutipleNFTsApi(HttpClient client, Moralis.EvmApi.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Moralis.EvmApi.Client.Configuration.MergeConfigurations(
                Moralis.EvmApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Moralis.EvmApi.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Moralis.EvmApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMutipleNFTsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public GetMutipleNFTsApi(Moralis.EvmApi.Client.ISynchronousClient client, Moralis.EvmApi.Client.IAsynchronousClient asyncClient, Moralis.EvmApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Moralis.EvmApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Moralis.EvmApi.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Moralis.EvmApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Moralis.EvmApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Moralis.EvmApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Moralis.EvmApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Multiple NFTs Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </summary>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <returns>List&lt;NftOwner&gt;</returns>
        public List<NftOwner> GetMultipleNFTs(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?))
        {
            Moralis.EvmApi.Client.ApiResponse<List<NftOwner>> localVarResponse = GetMultipleNFTsWithHttpInfo(getMultipleNftsDto, chain);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Multiple NFTs Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </summary>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <returns>ApiResponse of List&lt;NftOwner&gt;</returns>
        public Moralis.EvmApi.Client.ApiResponse<List<NftOwner>> GetMultipleNFTsWithHttpInfo(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?))
        {
            // verify the required parameter 'getMultipleNftsDto' is set
            if (getMultipleNftsDto == null)
                throw new Moralis.EvmApi.Client.ApiException(400, "Missing required parameter 'getMultipleNftsDto' when calling GetMutipleNFTsApi->GetMultipleNFTs");

            Moralis.EvmApi.Client.RequestOptions localVarRequestOptions = new Moralis.EvmApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Moralis.EvmApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Moralis.EvmApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (chain != null)
            {
                localVarRequestOptions.QueryParameters.Add(Moralis.EvmApi.Client.ClientUtils.ParameterToMultiMap("", "chain", chain));
            }
            localVarRequestOptions.Data = getMultipleNftsDto;

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Key", this.Configuration.GetApiKeyWithPrefix("X-API-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<List<NftOwner>>("/nft/getMultipleNFTs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMultipleNFTs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Multiple NFTs Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </summary>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;NftOwner&gt;</returns>
        public async System.Threading.Tasks.Task<List<NftOwner>> GetMultipleNFTsAsync(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Moralis.EvmApi.Client.ApiResponse<List<NftOwner>> localVarResponse = await GetMultipleNFTsWithHttpInfoAsync(getMultipleNftsDto, chain, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Multiple NFTs Returns an array of NFTs specified in the request. * Note that results will include all indexed NFTs * Any request that includes the token_address param will start the indexing process for that NFT collection the very first time it is requested. * Only 25 NFTs can be fetched in one API call.
        /// </summary>
        /// <exception cref="Moralis.EvmApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getMultipleNftsDto">Body</param>
        /// <param name="chain">The chain to query (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;NftOwner&gt;)</returns>
        public async System.Threading.Tasks.Task<Moralis.EvmApi.Client.ApiResponse<List<NftOwner>>> GetMultipleNFTsWithHttpInfoAsync(GetMultipleNftsDto getMultipleNftsDto, ChainList? chain = default(ChainList?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'getMultipleNftsDto' is set
            if (getMultipleNftsDto == null)
                throw new Moralis.EvmApi.Client.ApiException(400, "Missing required parameter 'getMultipleNftsDto' when calling GetMutipleNFTsApi->GetMultipleNFTs");


            Moralis.EvmApi.Client.RequestOptions localVarRequestOptions = new Moralis.EvmApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Moralis.EvmApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Moralis.EvmApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (chain != null)
            {
                localVarRequestOptions.QueryParameters.Add(Moralis.EvmApi.Client.ClientUtils.ParameterToMultiMap("", "chain", chain));
            }
            localVarRequestOptions.Data = getMultipleNftsDto;

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Key", this.Configuration.GetApiKeyWithPrefix("X-API-Key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<NftOwner>>("/nft/getMultipleNFTs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMultipleNFTs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}