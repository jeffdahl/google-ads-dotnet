// Copyright 2022 Google LLC
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
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V12.Services;

namespace Google.Ads.GoogleAds.Tests.V12.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetGroupServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateAssetGroupsRequestObject()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
                ValidateOnly = true,
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupsResponse response = client.MutateAssetGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAssetGroupsRequestObjectAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
                ValidateOnly = true,
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupsResponse responseCallSettings = await client.MutateAssetGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupsResponse responseCancellationToken = await client.MutateAssetGroupsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateAssetGroups()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupsResponse response = client.MutateAssetGroups(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAssetGroupsAsync()
        {
            moq::Mock<AssetGroupService.AssetGroupServiceClient> mockGrpcClient = new moq::Mock<AssetGroupService.AssetGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupOperation(),
                },
            };
            MutateAssetGroupsResponse expectedResponse = new MutateAssetGroupsResponse
            {
                Results =
                {
                    new MutateAssetGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupServiceClient client = new AssetGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupsResponse responseCallSettings = await client.MutateAssetGroupsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupsResponse responseCancellationToken = await client.MutateAssetGroupsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
