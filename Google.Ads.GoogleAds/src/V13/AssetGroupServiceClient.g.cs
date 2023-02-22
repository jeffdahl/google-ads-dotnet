// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V13.Services
{
    /// <summary>Settings for <see cref="AssetGroupServiceClient"/> instances.</summary>
    public sealed partial class AssetGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetGroupServiceSettings"/>.</returns>
        public static AssetGroupServiceSettings GetDefault() => new AssetGroupServiceSettings();

        /// <summary>Constructs a new <see cref="AssetGroupServiceSettings"/> object with default settings.</summary>
        public AssetGroupServiceSettings()
        {
        }

        private AssetGroupServiceSettings(AssetGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAssetGroupsSettings = existing.MutateAssetGroupsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetGroupServiceClient.MutateAssetGroups</c> and <c>AssetGroupServiceClient.MutateAssetGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAssetGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetGroupServiceSettings"/> object.</returns>
        public AssetGroupServiceSettings Clone() => new AssetGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetGroupServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class AssetGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetGroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetGroupServiceClientBuilder() : base(AssetGroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssetGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetGroupServiceClient Build()
        {
            AssetGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetGroupServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<AssetGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetGroupServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetGroupServiceClient.ChannelPool;
    }

    /// <summary>AssetGroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset group
    /// </remarks>
    public abstract partial class AssetGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetGroupService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetGroupService scopes.</summary>
        /// <remarks>
        /// The default AssetGroupService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssetGroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetGroupServiceClient"/>.</returns>
        public static stt::Task<AssetGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetGroupServiceClient"/>.</returns>
        public static AssetGroupServiceClient Create() => new AssetGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetGroupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetGroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssetGroupServiceClient"/>.</returns>
        internal static AssetGroupServiceClient Create(grpccore::CallInvoker callInvoker, AssetGroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetGroupService.AssetGroupServiceClient grpcClient = new AssetGroupService.AssetGroupServiceClient(callInvoker);
            return new AssetGroupServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AssetGroupService client</summary>
        public virtual AssetGroupService.AssetGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetGroupsResponse MutateAssetGroups(MutateAssetGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupsResponse> MutateAssetGroupsAsync(MutateAssetGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupsResponse> MutateAssetGroupsAsync(MutateAssetGroupsRequest request, st::CancellationToken cancellationToken) =>
            MutateAssetGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset groups are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset groups.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetGroupsResponse MutateAssetGroups(string customerId, scg::IEnumerable<AssetGroupOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetGroups(new MutateAssetGroupsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset groups are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset groups.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupsResponse> MutateAssetGroupsAsync(string customerId, scg::IEnumerable<AssetGroupOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetGroupsAsync(new MutateAssetGroupsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset groups are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset groups.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupsResponse> MutateAssetGroupsAsync(string customerId, scg::IEnumerable<AssetGroupOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAssetGroupsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetGroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset group
    /// </remarks>
    public sealed partial class AssetGroupServiceClientImpl : AssetGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAssetGroupsRequest, MutateAssetGroupsResponse> _callMutateAssetGroups;

        /// <summary>
        /// Constructs a client wrapper for the AssetGroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetGroupServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssetGroupServiceClientImpl(AssetGroupService.AssetGroupServiceClient grpcClient, AssetGroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssetGroupServiceSettings effectiveSettings = settings ?? AssetGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateAssetGroups = clientHelper.BuildApiCall<MutateAssetGroupsRequest, MutateAssetGroupsResponse>("MutateAssetGroups", grpcClient.MutateAssetGroupsAsync, grpcClient.MutateAssetGroups, effectiveSettings.MutateAssetGroupsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAssetGroups);
            Modify_MutateAssetGroupsApiCall(ref _callMutateAssetGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAssetGroupsApiCall(ref gaxgrpc::ApiCall<MutateAssetGroupsRequest, MutateAssetGroupsResponse> call);

        partial void OnConstruction(AssetGroupService.AssetGroupServiceClient grpcClient, AssetGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetGroupService client</summary>
        public override AssetGroupService.AssetGroupServiceClient GrpcClient { get; }

        partial void Modify_MutateAssetGroupsRequest(ref MutateAssetGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAssetGroupsResponse MutateAssetGroups(MutateAssetGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetGroupsRequest(ref request, ref callSettings);
            return _callMutateAssetGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes asset groups. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAssetGroupsResponse> MutateAssetGroupsAsync(MutateAssetGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetGroupsRequest(ref request, ref callSettings);
            return _callMutateAssetGroups.Async(request, callSettings);
        }
    }
}
